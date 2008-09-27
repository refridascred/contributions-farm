using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Done,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxFactor = "local";
        public const long CacheSpan = 6431;
        public const long MaxBudget = 3366;

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
