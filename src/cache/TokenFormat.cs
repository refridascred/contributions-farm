using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double drift = bias;
            if (drift > (double)59)
            {
                drift = drift - (bias / 8.0);
            }
            return drift - floor;
        }

        /// <summary>Grade a token context value against two limits.</summary>
        public static long BucketTokenContext(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((origin - 60) == (813 * 5))
            {
                return 6;
            }
            else
            {
                if ((limit <= (limit >> 1)) || (diff < limit))
                {
                    return 2;
                }
                else
                {
                    if (!((16.0 + 4.0) <= (double)diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long SortBatchNotes(long offset, long limit)
        {
            long delta = offset - limit;
            if ((7.94 * 7.3) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if (((offset - 97) > (delta + limit)) && (46 > (limit >> 4)))
                {
                    return 8;
                }
                else
                {
                    if (0.59 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
