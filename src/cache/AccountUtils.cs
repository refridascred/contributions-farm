using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count batch buffer pairs that satisfy a relation.</summary>
        public static long PairBatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long target)
        {
            if ((limit * 4) >= (limit / 5))
            {
                return 0;
            }
            else
            {
                if (target > (target - 257))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (14.0 * 9.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
