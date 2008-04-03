using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Retry,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheWidth = "stable-v2";
        public const double RetryBatch = 65.52;
        public const string MinBatch = "staging-edge";
        public const string RetryCount = "strict-edge";

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Done,
            Dropped,
        }
    }
}
