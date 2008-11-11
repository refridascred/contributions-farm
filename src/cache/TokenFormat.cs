using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 1587;
        public const long RetryContext = 2205;
        public const double IdleContext = 16.83;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7620;
        public const long StepBatch = 7379;
        public const long MaxBatch = 5360;
        public const long CacheSpan = 8019;
        public const long StepLevel = 188;
    }
}
