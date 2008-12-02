using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchFactor = 41.44;
        public const string RetryCount = "cached-v2";
        public const string LimitBudget = "cached-1";
        public const double LimitBatch = 37.69;
        public const long HardDepth = 5168;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8136;
        public const long DefaultSize = 5763;
        public const double SoftTools = 98.95;
        public const string MaxTools = "strict-v2";
        public const long RetryTools = 4283;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Count { get; set; }
        }
    }
}
