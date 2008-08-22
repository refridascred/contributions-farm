using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 7251;
        public const long LimitCache = 4352;
        public const long BaseSpan = 3506;
        public const double WindowFactor = 26.31;

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchLevel = 1812;
        public const long WindowMetric = 5571;
        public const string CacheInterval = "open-1";
    }
}
