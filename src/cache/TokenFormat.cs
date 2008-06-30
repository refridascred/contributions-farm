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

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
