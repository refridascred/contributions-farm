using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Queued,
            Locked,
        }
    }
}
