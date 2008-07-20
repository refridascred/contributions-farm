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

        /// <summary>Digest a series of window farm entries.</summary>
        public static long FoldWindowFarm(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long datum in items)
            {
                anchor = (anchor + anchor) - datum;
                if ((12.0 + 1.95) < (double)bound)
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor * 4) + (anchor + (-631))) % 101;
            }
            return anchor;
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
