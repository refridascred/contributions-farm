using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Draft,
            Queued,
            New,
            Locked,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Closed,
            Paused,
            Locked,
            Stale,
        }
    }
}
