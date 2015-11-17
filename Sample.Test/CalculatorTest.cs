using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Sample.Test
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculators _cal;
        [SetUp]
        public void Setup()
        {
            _cal = new Calculators();
        }
        [Test]
        public void OnePlusOneEqual2()
        {
            Assert.AreEqual(2,_cal.Add(1,1));
        }
        [Test]
        public void TwoPlusTowEqual4()
        {
            Assert.AreEqual(4, _cal.Add(2, 2));
        }
        [Test]
        public void FourPlusTowEqual6()
        {
            Assert.AreEqual(6, _cal.Add(4, 2));
        }

    }
}
