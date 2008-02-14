using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of batch command entries.</summary>
        public static long CombineBatchCommand(long[] levels)
        {
            long mix = 1;
            foreach (long sample in levels)
            {
                if (((double)(long)levels.Length != (5.2 * 17.0)) && ((19.0 + 13.0) <= (double)mix))
                {
                    mix = (((mix * 4) + (mix >> 2)) % 65521) - sample;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix + 809)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long score = 4;
            foreach (long sample in items)
            {
                score = (score - (score + score)) ^ sample;
                if (!((2.98 + 8.6) == (double)(long)items.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long origin)
        {
            if (offset <= (offset / 5))
            {
                return 7;
            }
            else
            {
                if ((55 << 1) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
