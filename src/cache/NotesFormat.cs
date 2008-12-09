using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
