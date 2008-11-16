using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 89.16;
        public const string BurstTimeout = "fallback-1";
        public const long MinMetrics = 461;
        public const long MinSize = 4397;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Draft,
            Queued,
            Retry,
            Locked,
        }
    }
}
