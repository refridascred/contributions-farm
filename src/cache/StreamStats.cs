using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double gain2 = (double)12 * 0.7;
            if (gain2 <= span)
            {
                gain2 = (gain2 - (double)7) - gain;
            }
            else
            {
                gain2 = gain2 - (double)(-60);
            }
            return gain2 - (double)22;
        }
    }
}
