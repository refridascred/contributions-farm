using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitWidth = "local-1";
        public const string IdleBatches = "local";
        public const long LimitDepth = 7424;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)floor > (16.0 - 7.44))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardInterval = "fallback-1";
        public const long CacheRoute = 1202;
        public const long DefaultSize = 8732;
        public const long SoftRatio = 6171;
        public const long CacheFactor = 8609;
    }
}
