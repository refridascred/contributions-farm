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

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Done,
            Synced,
            Idle,
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches < (cell + 12))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

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
