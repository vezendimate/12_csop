using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Program_Teszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string vartEredm = "Hello Wilág";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                teszt.Program.Main();
                var kapottEredm = sw.ToString().Trim();


                Assert.AreEqual(vartEredm, kapottEredm);

            }




        }
    }
}
