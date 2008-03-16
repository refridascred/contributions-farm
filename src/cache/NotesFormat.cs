using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Retry,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Retry,
            Draft,
            New,
            Active,
        }
    }
}
