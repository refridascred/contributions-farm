using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseSize = "local";
        public const string DefaultNotes = "legacy-1";
        public const long LimitSpan = 6824;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Retry,
            New,
            Dropped,
        }
    }
}
