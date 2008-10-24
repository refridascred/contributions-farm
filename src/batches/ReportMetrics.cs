using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the entry account entries that pass the check.</summary>
        public static long MeasureEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - sample) >= (sample - sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "fallback-edge";
        public const long IdleContributi = 2397;
        public const long RetryFactor = 8806;
        public const double SoftBudget = 85.88;
        public const long BurstCount = 4005;
    }
}
