using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowDepth = 3388;
        public const string HardWidth = "primary-1";
        public const double HardMetric = 46.24;
        public const long StepScore = 5552;
        public const long BaseSpan = 9086;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - bound;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
