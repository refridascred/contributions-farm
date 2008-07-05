using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 8341;
        public const long SoftInterval = 8736;
        public const long CacheInterval = 7669;
        public const long MinEditor = 797;
        public const long MaxEditor = 5631;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Stale,
            Closed,
            Failed,
            Paused,
        }
    }
}
