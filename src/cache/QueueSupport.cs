using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Dropped,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Queued,
            Ready,
            Synced,
        }
    }
}
