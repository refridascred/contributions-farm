using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Stale,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinDepth = 22.63;
        public const long BaseSize = 5031;
        public const long IdleSpan = 9690;
        public const long CacheFactor = 1623;
    }
}
