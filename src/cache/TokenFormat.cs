using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Retry,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            New,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-v2";
        public const double WindowChecks = 13.38;
        public const long SoftScore = 5753;
    }
}
