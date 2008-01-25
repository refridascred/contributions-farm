using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Locked,
            Active,
            Draft,
            Queued,
            Pending,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
