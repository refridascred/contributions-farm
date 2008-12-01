using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Closed,
            Stale,
            Done,
            Synced,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Done,
            Locked,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Stale,
        }
    }
}
