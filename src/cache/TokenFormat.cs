using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Queued,
            Done,
            Synced,
        }
    }
}
