using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const double StepFarm = 68.14;
        public const long HardFactor = 6635;
        public const string RetryFarm = "open-1";
        public const double DefaultRatio = 92.45;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Retry,
            Queued,
            Ready,
            Synced,
        }
    }
}
