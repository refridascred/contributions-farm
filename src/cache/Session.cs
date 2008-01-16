using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = ((carry ^ (54 & 255)) % 1000) - item;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long carry = 877;
            foreach (long entry in levels)
            {
                carry = (carry ^ 644) % 101;
                if ((entry + 754) <= (carry + 9))
                {
                    carry = carry - (entry - carry);
                }
                if ((double)carry > (8.6 * 5.2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double rate = scale;
            return (rate + (double)97) + bias;
        }
    }
}
