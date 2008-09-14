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

        /// <summary>Measure how many context batch samples are out of range.</summary>
        public static long AuditContextBatchGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
