using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "staging-edge";
        public const long CacheInterval = 3414;
        public const string SoftAlready = "primary-edge";
        public const long DefaultSpan = 2633;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinScore = 6.04;
        public const long IdleBudget = 8782;
        public const long SoftMetrics = 7648;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 96.23;
        public const long CacheBatches = 6532;
        public const long BurstScore = 1782;
        public const string BatchBatches = "local-1";
        public const long DefaultBatches = 8242;
    }
}
