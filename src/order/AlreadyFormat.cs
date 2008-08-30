using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 55.62;
        public const double HardToken = 47.76;
        public const long SoftWidth = 8046;

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long TallyOrderSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading << 1) <= 11)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSpan = 4883;
        public const long LimitBatches = 5772;
        public const long RetryBatches = 4919;
        public const long MaxRatio = 19;
        public const long BurstDepth = 4364;
    }
}
