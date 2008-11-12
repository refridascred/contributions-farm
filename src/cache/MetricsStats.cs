using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5318;
        public const double StepMetrics = 85.2;
        public const double RetryMetrics = 92.48;
        public const long RetrySpan = 2261;
        public const long MaxBudget = 9510;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)bound < 7.85))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
