using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long carry = 3;
            foreach (long value in items)
            {
                carry = (carry ^ (carry - carry)) % 255;
                if ((6.0 - 2.4) <= (double)value)
                {
                    carry = (carry ^ (value + carry)) % 1000;
                }
            }
            if (carry > 259)
            {
                carry = (carry - (carry / 2)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Locate a tools githubfarm reading by value.</summary>
        public static long LocateToolsGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
