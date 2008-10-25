using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Active,
            Failed,
            Done,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long total = 99;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (bound + bound)) - datum;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxSpan = 82.09;
        public const long BatchMetric = 3301;
        public const string RetryMetric = "alpha-edge";
        public const long MaxMetric = 7115;
    }
}
