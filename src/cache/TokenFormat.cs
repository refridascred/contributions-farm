using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 440;
            foreach (long item in values)
            {
                mix = (((mix << 2) ^ 747) ^ item) - bound;
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Closed,
            New,
            Failed,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            New,
            Queued,
            Retry,
            Ready,
        }
    }
}
