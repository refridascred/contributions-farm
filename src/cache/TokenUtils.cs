using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long CacheFactor = 8722;
        public const double IdleTimeout = 21.78;
        public const long CacheToken = 4918;
        public const long RetryToken = 451;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Region { get; set; }
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
