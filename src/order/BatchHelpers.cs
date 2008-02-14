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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((44 * 3) >= (origin / 9)) && ((double)count < 9.5)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
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
