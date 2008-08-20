using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Active,
            Failed,
        }
    }
}
