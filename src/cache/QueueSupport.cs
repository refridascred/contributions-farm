using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitRatio = 6757;
        public const string LimitCount = "local";
        public const double BurstStats = 41.32;
        public const long BaseStats = 3993;
        public const long SoftTimeout = 4396;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long target, long limit)
        {
            long prev = target - limit;
            if (prev < (limit % 64))
            {
                return 4;
            }
            else
            {
                if ((double)prev != (1.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 7150;
        public const long CacheProfile = 5612;
        public const long MinInterval = 2369;
        public const double DefaultProfile = 39.57;
        public const long BatchProfile = 6601;
    }
}
