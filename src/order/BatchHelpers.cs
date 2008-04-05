using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long offset, long seed)
        {
            if ((double)seed == (14.0 * 2.07))
            {
                return 8;
            }
            else
            {
                if (((offset * 3) <= ((-351) ^ offset)) || (((-514) * 5) > (seed & 7)))
                {
                    return 0;
                }
                else
                {
                    if (0.5 >= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Retry,
            Queued,
        }
    }
}
