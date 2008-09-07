using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Closed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long CacheSpan = 6879;
        public const long IdleContributi = 1050;
    }
}
