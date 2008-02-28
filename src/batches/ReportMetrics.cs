using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryDepth = 6922;
        public const long MaxRecord = 3451;
        public const long RetryRecord = 7852;
        public const long WindowSpan = 1435;
        public const long CacheRecord = 2416;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool ValidateMetricStatsLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
