using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Stale,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 5219;
        public const string CacheWidth = "strict-v2";
        public const long SoftCommand = 5293;
        public const string HardScore = "open";
        public const string RetryWidth = "cached";
    }
}
