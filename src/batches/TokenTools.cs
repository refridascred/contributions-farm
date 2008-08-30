using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitDepth = 28.32;
        public const double MinProfile = 9.55;
        public const long BurstRatio = 8704;
        public const long IdleBudget = 7725;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (((item + item) != (carry - item)) && ((carry ^ carry) > item))
                {
                    carry = ((carry * 4) + (item - 962)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Derive the next cluster stats value from a seed.</summary>
        public static long DeriveClusterStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 21; i++)
            {
                if (target <= 4)
                {
                    acc = (acc + ((long)i + (long)i)) % 1000;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
