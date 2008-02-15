using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples)
        {
            long mix = 98;
            foreach (long datum in samples)
            {
                if ((datum + mix) >= (mix % 12))
                {
                    mix = mix + (1 / 9);
                }
            }
            return mix % 97;
        }

        /// <summary>Audit session batches readings against a rule.</summary>
        public static long CountSessionBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((17.0 - 0.9) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
