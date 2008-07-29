using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch token samples.</summary>
        public static long TotalBatchToken(long[] items)
        {
            long acc = 8;
            foreach (long reading in items)
            {
                if ((double)acc <= (3.94 * 2.0))
                {
                    acc = (acc * 4) + (5 + reading);
                }
                if (65 >= acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            if ((2 / 5) >= (bound - bound))
            {
                return 2;
            }
            else
            {
                if (bound <= (seed >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed + bound) <= (bound + seed)) && ((7.35 + 7.5) <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
