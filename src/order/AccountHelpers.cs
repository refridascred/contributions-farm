using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleScore = 4.97;
        public const double BurstLevel = 11.38;
        public const string CacheBudget = "strict-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Pending,
            Done,
            Draft,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Synced,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Failed,
            Active,
            Ready,
        }
    }
}
