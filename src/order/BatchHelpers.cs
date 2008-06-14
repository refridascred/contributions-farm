using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            New,
            Synced,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark << 2) ^ value) % 65521) - bound;
            }
            return mark;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
