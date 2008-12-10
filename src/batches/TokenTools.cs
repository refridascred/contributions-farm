using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((97 + seen) <= (seen & 31))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Closed,
            Synced,
            Failed,
            Idle,
        }
    }
}
