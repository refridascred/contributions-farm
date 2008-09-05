using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cluster buffer sample.</summary>
        public static long SeekClusterBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if (817 < seed)
                {
                    mark = (mark ^ ((long)values.Length >> 3)) % 1000;
                }
                else
                {
                    mark = mark ^ (seed + datum);
                }
            }
            return mark % 4096;
        }
    }
}
