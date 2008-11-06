using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache support reading.</summary>
        public static double BlendCacheSupport(double scale, double floor)
        {
            double load = floor;
            return (load - (19.0 - load)) + scale;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
