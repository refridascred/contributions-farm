using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Draft,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Draft,
            Active,
            Pending,
        }
    }
}
