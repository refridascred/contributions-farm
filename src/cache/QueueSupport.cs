using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2881;
        public const double BurstWidth = 25.48;
        public const long HardDepth = 3593;
        public const long SoftCommand = 1295;
        public const long RetryBudget = 1186;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-edge";
        public const string LimitFactor = "local-edge";
        public const long SoftWidth = 3598;
    }
}
