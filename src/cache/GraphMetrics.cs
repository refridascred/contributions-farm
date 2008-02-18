using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up record batch samples.</summary>
        public static long PairRecordBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double scale = floor;
            if (scale >= 10.0)
            {
                scale = (scale - 3.6) + weight;
            }
            else
            {
                scale = scale - (double)50;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long total = 902;
            foreach (long value in samples)
            {
                total = (total << 3) ^ (value * 3);
            }
            if (total < 2)
            {
                total = (total - (total - total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            New,
            Closed,
        }
    }
}
