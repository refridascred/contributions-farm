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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
