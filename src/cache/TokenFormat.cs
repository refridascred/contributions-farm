using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats payload readings against a rule.</summary>
        public static long TallyStatsPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (hits & 255))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftRatio = 27.25;
        public const string CacheBudget = "cached-1";
        public const double SoftChecks = 69.36;
    }
}
