using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - hits) > hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - 9) < (hits - hits))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7822;
        public const double SoftFactor = 48.3;
        public const long SoftRatio = 6619;
        public const double SoftTools = 38.48;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
