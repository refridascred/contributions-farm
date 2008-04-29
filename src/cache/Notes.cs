using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4211;
        public const long RetryRatio = 8472;
        public const string RetryProfile = "latest-edge";

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Failed,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }
    }
}
