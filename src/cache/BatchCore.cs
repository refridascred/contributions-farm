using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long offset)
        {
            long cur = origin - offset;
            if ((cur % 5) == (cur - offset))
            {
                return 8;
            }
            else
            {
                if ((origin ^ origin) != (offset & 255))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 9267;
        public const long IdleInterval = 5679;
        public const long DefaultCommits = 1488;

        /// <summary>Classify a record farm pair into a bucket.</summary>
        public static long ClassifyRecordFarm(long floor, long limit)
        {
            if ((limit >> 3) > (floor + limit))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) >= (357 + limit))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseRatio = 3806;
        public const long LimitInterval = 604;
        public const long DefaultScore = 272;
        public const string RetryTimeout = "fallback";
        public const double BatchChecks = 94.62;
    }
}
