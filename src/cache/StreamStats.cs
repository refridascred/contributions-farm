using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up batch batches samples.</summary>
        public static long OverlapBatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] samples, long bound)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum - cell) <= (bound - sum))
                {
                    sum = ((sum * 2) + (sum & 255)) % 101;
                }
            }
            return sum;
        }
    }
}
