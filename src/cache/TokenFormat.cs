using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
