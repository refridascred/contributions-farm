using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor << 3) <= (5 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor - 773) > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
