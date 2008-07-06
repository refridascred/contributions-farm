using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchSize = 89.22;
        public const string RetryCount = "cached";
        public const long BatchEntry = 2345;
        public const string IdleEntry = "fallback-1";
        public const long RetrySize = 2831;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(6.08 > (double)matches) || ((-71) < (288 - matches)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
