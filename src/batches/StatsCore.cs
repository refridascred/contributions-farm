using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items, long bound)
        {
            long acc = 79;
            foreach (long entry in items)
            {
                acc = (acc + (entry >> 3)) + bound;
            }
            return acc % 97;
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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((6.0 - 3.6) == (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
