using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Synced,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 7716;
        public const string IdleFactor = "fallback-v2";
        public const long RetryBatches = 4232;
        public const long CacheBatches = 3432;
        public const long DefaultBatches = 6727;
    }
}
