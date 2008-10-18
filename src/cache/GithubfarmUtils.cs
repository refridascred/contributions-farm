using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Failed,
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
