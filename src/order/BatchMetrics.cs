using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Label { get; set; }
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

        /// <summary>Measure how many session queue samples are out of range.</summary>
        public static long MeasureSessionQueueOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((-8) >= (587 + hits)) || ((double)target != (3.98 - 5.43))) && !((entry + entry) <= (entry % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

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
