using BugPro;

namespace BugTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bug = new Bug(Bug.State.Open);
            bug.Assign();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Assigned, state);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var bug = new Bug(Bug.State.Open);
            Assert.Throws<InvalidOperationException>(() => bug.Close());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var bug = new Bug(Bug.State.Open);
            Assert.Throws<InvalidOperationException>(() => bug.Defer());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var bug = new Bug(Bug.State.Assigned);
            bug.Close();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Closed, state);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var bug = new Bug(Bug.State.Assigned);
            bug.Defer();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Defered, state);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var bug = new Bug(Bug.State.Assigned);
            bug.Assign();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Assigned, state);
        }

        [TestMethod]
        public void TestMethod7()
        {
            var bug = new Bug(Bug.State.Closed);
            bug.Assign();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Assigned, state);
        }

        [TestMethod]
        public void TestMethod8()
        {
            var bug = new Bug(Bug.State.Closed);
            Assert.Throws<InvalidOperationException>(() => bug.Close());
        }

        [TestMethod]
        public void TestMethod9()
        {
            var bug = new Bug(Bug.State.Closed);
            Assert.Throws<InvalidOperationException>(() => bug.Defer());
        }

        [TestMethod]
        public void TestMethod10()
        {
            var bug = new Bug(Bug.State.Defered);
            bug.Assign();
            var state = bug.getState();
            Assert.AreEqual(Bug.State.Assigned, state);
        }

        [TestMethod]
        public void TestMethod11()
        {
            var bug = new Bug(Bug.State.Defered);
            Assert.Throws<InvalidOperationException>(() => bug.Close());
        }

        [TestMethod]
        public void TestMethod12()
        {
            var bug = new Bug(Bug.State.Defered);
            Assert.Throws<InvalidOperationException>(() => bug.Defer());
        }
    }
}
