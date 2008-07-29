using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a profile batches pair into a bucket.</summary>
        public static long SortProfileBatches(long bound, long floor)
        {
            if ((double)floor == (5.79 + 8.4))
            {
                return 1;
            }
            else
            {
                if (((bound / 4) < bound) && ((bound >> 3) != (bound - floor)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) <= (floor % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
