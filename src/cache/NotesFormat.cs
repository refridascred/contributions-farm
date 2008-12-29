using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 6114;
        public const long BaseMetric = 9563;
        public const string BurstWidth = "alpha";

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
