using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstRatio = 52.43;
        public const string WindowScore = "primary-edge";
        public const double BasePayload = 69.51;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((6.93 - 5.2) != (double)seen))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitLevel = 84.8;
        public const long CacheContributi = 8331;
        public const long StepTimeout = 9548;
        public const long RetryContributi = 9812;
        public const string BaseContributi = "local";
    }
}
