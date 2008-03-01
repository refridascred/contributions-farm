using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a support batches value against two limits.</summary>
        public static long BucketSupportBatches(long floor, long limit)
        {
            long slot = floor + limit;
            if (!((floor & 63) < limit))
            {
                return 1;
            }
            else
            {
                if (slot >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long acc = 5;
            foreach (long reading in data)
            {
                if ((8 << 2) != (offset / 4))
                {
                    acc = (acc - (acc + offset)) % 101;
                    break;
                }
                else
                {
                    acc = ((acc * 2) + (offset + reading)) % 4096;
                }
                acc = ((acc << 2) ^ (offset % 5)) % 101;
                if ((offset - acc) > (99 / 8))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
