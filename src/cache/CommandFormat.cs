using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "standard-edge";
        public const long BaseTools = 805;
        public const string CacheScore = "primary";
        public const double CacheFactor = 18.06;
        public const string RetryCount = "staging-edge";

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 88.36;
        public const double MaxRatio = 52.06;
        public const long MaxSize = 1169;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
