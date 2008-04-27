using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((double)origin2 < 4.11)
            {
                return 5;
            }
            else
            {
                if ((origin >> 5) >= (origin2 % 8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long bound)
        {
            if ((double)8 != (double)bound)
            {
                return 3;
            }
            else
            {
                if (5.98 > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound == (double)origin) && ((2 * 2) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxFactor = 61.31;
        public const double DefaultCache = 38.48;
        public const long BurstBudget = 787;
        public const string BurstScore = "latest-v2";
    }
}
