using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 1731;
        public const double LimitReport = 7.58;
        public const long MinWidth = 1506;
        public const long BatchSize = 7870;
    }
}
