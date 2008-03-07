using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Ratio { get; set; } = "";
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
