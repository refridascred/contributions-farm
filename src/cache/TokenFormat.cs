using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (hits <= 1)
                {
                    hits = ((hits + 3) + value) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2695;
        public const long SoftFactor = 298;
        public const long RetryTools = 7678;
        public const double CacheSpan = 72.76;
    }
}
