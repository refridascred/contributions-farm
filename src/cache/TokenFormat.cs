using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) < (sample / 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 6901;
        public const long StepLevel = 3899;
        public const long MaxRatio = 9588;
        public const long BatchInterval = 8415;
        public const double RetryMetrics = 84.3;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "local-1";
        public const double SoftRatio = 73.26;
        public const double StepMetric = 27.03;
    }
}
