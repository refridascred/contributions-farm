using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 50;
            foreach (long sample in data)
            {
                mark = (mark ^ (mark & 63)) + sample;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 813;
            foreach (long entry in levels)
            {
                sum = (sum ^ (990 - entry)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Adjust a batches schema reading.</summary>
        public static double SmoothBatchesSchema(double rate, double floor)
        {
            double drift = 7.4;
            if (drift >= rate)
            {
                drift = drift + floor;
            }
            return drift + floor;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
