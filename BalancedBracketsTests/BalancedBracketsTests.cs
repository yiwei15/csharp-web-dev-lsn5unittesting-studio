using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        // Test1: Add emptyTest so we can configure our runtime environment
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }


        //Test2: Verify HasBalancedBrackets method returns "true" if the 
        //input string ONLY has "[]"; 
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Test3: Verify HasBalancedBrackets method returns "true" 
        //if input sting has characters within a pair of bracket. "[LaunchCode]"

        [TestMethod]
        public void OrderedBracketsWithCharactersIn()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        //Test4: Verify HasBalancedBrackets method returns "true"
        //if input string has a pairs of empty backets in front. "[]LaunchCode"

        [TestMethod]
        public void OrderedBracketsAtBeginning()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        //Test5: Verify HasBalancedBrackets method returns "true"
        //if input string is empty.  ""

        [TestMethod]
        public void EmptyString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Test6: Verify HasBalancedBrackets method returns "true"
        //if input string does not have any bracket.  "LaunchCode"

        [TestMethod]
        public void NoBracketString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        //Test7: Verify HasBalancedBrackets method returns "true"
        //if input string has more than pair of ordered brackets.  ""

        [TestMethod]
        public void MoreThanOnePairOrderedBrackets1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]]"));
        }

        //Test8: Verify HasBalancedBrackets method returns "true"
        //if input string has a pair of empty brackets at last. "[][]"

        [TestMethod]
        public void MoreThanOnePairOrderedBrackets2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch][Code]"));
        }

        //Test9: Verify HasBalancedBrackets method returns "false"
        //if input string has only opening bracket.  "[LaunchCode";

        [TestMethod]
        public void OnlyOpeningBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }


        //Test10: Verify HasBalancedBrackets method returns "false"
        //if input string has only closing bracket.  "LaunchCode]";

        [TestMethod]

        public void OnlyClosingBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("LaunchCode]"));
        }

        //Test11: Verify HasBalancedBrackets method returns "false"
        //if input string has closing bracket before opening bracket. a "]LaunchCode[";

        [TestMethod]
        public void DisorderedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }


        //Test12: Verify HasBalancedBrackets method returns "false"
        //if input string has more opening brackets than closing brackets one opening brakets. "[[]";

        [TestMethod]

        public void MoreOpeningBracketsBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[LaunchCode]"));
        }

        //Test13: Verify HasBalancedBrackets method returns "false"
        //if input string has more closing brackets than opening brackets one opening brakets. "[]]";

        [TestMethod]
        public void MoreClosingBracketsBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launch]Code]"));
        }


    }
}
