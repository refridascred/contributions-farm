using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Failed,
            New,
            Retry,
            Queued,
        }
    }
}
