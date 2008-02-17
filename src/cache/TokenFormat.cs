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

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
