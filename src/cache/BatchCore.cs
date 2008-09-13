using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Level { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long bound)
        {
            long state = -9;
            foreach (long datum in series)
            {
                if ((-42) < (state << 2))
                {
                    state = ((((state << 2) ^ (1 / 2)) % 101) ^ datum) + bound;
                }
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long floor)
        {
            long mark = 806;
            foreach (long reading in levels)
            {
                if ((floor <= (161 / 9)) && ((mark >> 1) < ((-111) + floor)))
                {
                    mark = mark ^ (reading / 7);
                }
            }
            if (mark > 6)
            {
                mark = (mark ^ (75 / 8)) % 4096;
            }
            return mark % 4096;
        }
    }
}
