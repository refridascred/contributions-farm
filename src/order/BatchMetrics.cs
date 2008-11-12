using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6354;
        public const string BatchChannel = "cached";
        public const long RetryWidth = 5469;
        public const long BurstSpan = 3173;
        public const long LimitTimeout = 7509;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long floor)
        {
            if (67 > (origin ^ floor))
            {
                return 4;
            }
            else
            {
                if (((floor + floor) > (32 * 2)) && (floor >= (floor << 2)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((target % 97) == (value ^ value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 9493;
        public const string IdleMetrics = "fallback-1";
        public const long StepSpan = 8099;
        public const long CacheMetrics = 556;
        public const long IdleSpan = 3012;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Active,
            Locked,
            Done,
            Failed,
        }
    }
}
