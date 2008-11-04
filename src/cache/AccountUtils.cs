using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 127) >= (count + origin))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
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
