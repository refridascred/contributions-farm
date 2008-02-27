using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long StepEditorSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (81 ^ score)) % 1000;
                score = ((score * 4) + (bound + bound)) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 27;
        public const long MinSize = 3278;
        public const long LimitSpan = 5089;
        public const double LimitGithubfarm = 19.05;
        public const double LimitWidth = 96.21;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "staging-1";
        public const long DefaultDepth = 9364;
        public const long CacheStream = 4407;
        public const long BaseStream = 4790;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Stale,
            Retry,
            Active,
        }
    }
}
