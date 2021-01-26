using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;
namespace OperazioniTests
{
    [TestClass]
    public class GestioneTest
    {
        [TestMethod]
        public void TestSommaPositivi()
        {
            int a = 3;
            int b = 7;
            int somma_aspettata = 10;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public static void TestSommanulli()
        {
            int a = 0;
            int b = 0;
            int somma_aspettata = 0;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public static void TestSommanegativi()
        {
            int a = -3;
            int b = -2;
            int somma_aspettata = -5;
            int somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
        [TestMethod]
        public static void TestSommareali()
        {
            double a = 4.5;
            double b = 2.5;
            double somma_aspettata = -7;
            double somma_effettiva;
            somma_effettiva = Gestione.Somma(a, b);
            Assert.AreEqual(somma_aspettata, somma_effettiva);
        }
    }
}
