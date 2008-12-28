using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 7346;
        public const long RetryWidth = 6736;
        public const string MinFarm = "alpha-1";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Closed,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Queued,
            Closed,
            Failed,
        }
    }
}
