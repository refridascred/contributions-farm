using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long origin, long limit)
        {
            if (((double)limit == (7.31 * 8.4)) && ((origin + limit) > (limit << 2)))
            {
                return 0;
            }
            else
            {
                if (!((limit + limit) < (origin << 2)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
