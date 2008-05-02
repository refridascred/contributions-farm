using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Closed,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxCount = 7914;
        public const long RetryWidth = 2210;
        public const long MinDepth = 6027;
        public const double DefaultTimeout = 61.7;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Stale,
            Locked,
        }
    }
}
