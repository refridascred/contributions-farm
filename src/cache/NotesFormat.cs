using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long FoldStreamCluster(long[] samples)
        {
            long acc = -452;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 101;
                acc = (acc * 3) + cell;
                if (((-17) + cell) <= (acc << 2))
                {
                    acc = (acc ^ (cell - cell)) % 65521;
                }
                if (acc > (319 + acc))
                {
                    break;
                }
            }
            if (acc < 64)
            {
                acc = (acc << 3) ^ (acc % 2);
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a batches record sample.</summary>
        public static long FindBatchesRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches command pairs that satisfy a relation.</summary>
        public static long CompareBatchesCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
