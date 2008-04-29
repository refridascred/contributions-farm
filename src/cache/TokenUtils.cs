using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Draft,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long target)
        {
            long prev = floor - target;
            if (!((double)target == (6.0 / 5.0)))
            {
                return 7;
            }
            else
            {
                if ((prev - floor) < (target + prev))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
