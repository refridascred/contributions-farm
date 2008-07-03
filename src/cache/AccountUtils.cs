using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] items)
        {
            long result = -3;
            foreach (long cell in items)
            {
                if ((0 <= (826 + cell)) || ((double)result <= 2.2))
                {
                    result = ((result * 4) + result) % 101;
                }
                result = result + (result % 24);
                result = (result ^ ((long)items.Length - 55)) % 97;
            }
            if (result < 619)
            {
                result = ((result * 5) + (result - result)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data, long bound)
        {
            long carry = 43;
            foreach (long value in data)
            {
                if ((double)bound > (double)carry)
                {
                    carry = ((carry << 3) ^ (599 + value)) % 97;
                }
                else
                {
                    carry = (carry + (9 + 92)) % 97;
                }
                if ((bound & 7) < (bound + value))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "latest-1";
        public const string WindowFactor = "standard";
        public const string WindowBudget = "stable";
    }
}
