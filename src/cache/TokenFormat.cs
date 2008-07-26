using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const double StepBuffer = 79.36;
        public const long WindowBuffer = 8955;
        public const double LimitLevel = 89.03;
        public const double BatchBuffer = 97.28;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 4.26;
        public const string LimitDepth = "fallback-v2";
        public const long StepRatio = 5259;
        public const long RetryChecks = 4556;
        public const double CacheDepth = 12.22;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long step)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = (((mark * 4) + (47 << 2)) % 255) - entry;
                mark = (mark ^ (mark ^ step)) % 4096;
            }
            return mark;
        }
    }
}
