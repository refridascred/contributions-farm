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

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long origin)
        {
            long anchor = 51;
            foreach (long entry in series)
            {
                anchor = ((anchor << 2) ^ (origin + origin)) % 65521;
                anchor = ((anchor << 3) ^ (anchor / 7)) % 255;
                if ((origin << 2) == (entry >> 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
