using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 432;
        public const long RetryBudget = 4030;
        public const long BaseDepth = 9070;
        public const long BaseStream = 7242;
        public const long HardStream = 5678;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (limit > (bound & 3))
            {
                return 8;
            }
            else
            {
                if (((double)cur <= (3.44 + 5.0)) || ((0.5 + 4.0) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (cur > (bound / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long origin2)
        {
            long next = origin ^ origin2;
            if (((4.5 * 7.54) <= (double)next) || ((origin + (-647)) < next))
            {
                return 5;
            }
            else
            {
                if (5.97 < (double)origin2)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
