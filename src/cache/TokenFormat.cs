using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchSize = 36.21;
        public const string SoftSpan = "strict";
        public const long StepBudget = 1487;
        public const long BurstDepth = 1452;

        /// <summary>Count the farm buffer entries that pass the check.</summary>
        public static long MeasureFarmBufferOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((double)seen == (2.64 - 8.9)) || ((double)seen != (5.8 / 8.0))))
                {
                    seen = ((seen + 2) ^ value) + seed;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
