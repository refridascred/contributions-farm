using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (count <= (count + count))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long mark = 29;
            foreach (long sample in readings)
            {
                if (sample >= (limit << 3))
                {
                    mark = (mark << 3) ^ (mark * 5);
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }
    }
}
