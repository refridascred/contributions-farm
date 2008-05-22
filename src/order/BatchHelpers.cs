using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up channel cluster samples.</summary>
        public static long MatchChannelClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] levels)
        {
            long sum = 4;
            foreach (long item in levels)
            {
                if ((double)item > (double)sum)
                {
                    sum = ((sum * 4) + (item + 441)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
