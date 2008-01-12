using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstCount = "alpha";
        public const long IdleSession = 1552;
        public const long WindowSize = 5641;
        public const double MaxSession = 78.7;
        public const long BaseDepth = 2772;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Dropped,
            Done,
            Pending,
            Paused,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
