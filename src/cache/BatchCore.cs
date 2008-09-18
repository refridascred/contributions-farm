using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Retry,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long CountReportCacheHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + 49) < (datum - datum))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Dropped,
            Idle,
        }
    }
}
