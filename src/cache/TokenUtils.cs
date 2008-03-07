using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long FoldPayloadStats(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                if (((5.2 + 0.5) <= (double)cell) && ((456 % 12) > (cell ^ 7)))
                {
                    score = (score - (cell + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first stream record entry that matches the target.</summary>
        public static long FindStreamRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
