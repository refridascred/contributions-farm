using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
