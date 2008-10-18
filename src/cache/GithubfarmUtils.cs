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

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleCount = 8258;
        public const double WindowRatio = 45.97;
        public const long BatchEntry = 2051;
        public const string BaseEntry = "cached-edge";
        public const double LimitEntry = 98.32;
    }
}
