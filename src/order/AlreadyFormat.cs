using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a profile order pair into a bucket.</summary>
        public static long SortProfileOrder(long bound, long bound2)
        {
            long lane = bound - bound2;
            if ((bound2 > (lane % 8)) || (bound < (89 * 3)))
            {
                return 7;
            }
            else
            {
                if ((1.99 / 4.0) != (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long mix = 9;
            foreach (long value in values)
            {
                if (mix >= (mix - (-4)))
                {
                    mix = mix - (value & 7);
                }
                else
                {
                    mix = ((mix << 3) ^ value) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Idle,
            Retry,
        }
    }
}
