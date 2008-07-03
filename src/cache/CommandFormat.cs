using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Pending,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Retry,
            Active,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Draft,
            Idle,
            Locked,
            Queued,
        }
    }
}
