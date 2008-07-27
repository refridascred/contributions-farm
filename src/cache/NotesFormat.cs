using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultLevel = "alpha-v2";
        public const long LimitSize = 6112;
        public const string MaxTimeout = "staging-edge";
        public const long RetryScore = 6517;
        public const long BurstWindow = 9714;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
