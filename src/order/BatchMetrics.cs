using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9284;
        public const double HardBudget = 61.96;
        public const double DefaultMetrics = 15.43;
        public const long DefaultSpan = 7988;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "local-v2";
        public const long StepSupport = 4393;
        public const long MinSupport = 2658;
        public const long SoftSupport = 2024;
        public const long WindowTimeout = 2010;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
