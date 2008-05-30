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

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
