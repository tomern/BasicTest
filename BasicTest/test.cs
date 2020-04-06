using NUnit.Framework;
using System;

namespace BasicTest
{
    public class Test
    {
        [Test]
        public void TestNuber1()
        {
            Console.WriteLine("Pass");
            Assert.IsTrue(true, "Test Passed");
        }
    }
}
