using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstFactor = "primary";
        public const long BaseBudget = 9505;
        public const long WindowTimeout = 6033;
        public const long HardBatches = 1614;
        public const long LimitSize = 4604;
    }
}
