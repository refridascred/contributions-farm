using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "staging";
        public const double BurstFactor = 25.5;
        public const string StepTimeout = "local";
        public const long IdleMetrics = 6105;
        public const long RetryMetrics = 1448;

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)hits <= 8.6))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry - seen) > (seen + 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings, long seed)
        {
            long total = 8;
            foreach (long value in readings)
            {
                if ((value - seed) == (seed >> 1))
                {
                    total = ((total << 2) ^ seed) % 4096;
                    continue;
                }
                if ((seed ^ seed) <= (seed >> 4))
                {
                    total = (total + (87 - seed)) % 4096;
                }
                else
                {
                    total = total + (total ^ value);
                }
                if ((seed ^ value) != (seed + value))
                {
                    break;
                }
            }
            return total;
        }
    }
}
