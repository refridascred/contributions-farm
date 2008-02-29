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

        /// <summary>Define session limits and defaults.</summary>
        public const long MinInterval = 8022;
        public const long WindowSession = 8973;
        public const long MinCount = 57;
        public const double SoftSession = 44.48;

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
