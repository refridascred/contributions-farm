using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double mean = ratio / 8.0;
            if (mean > (mean + 7.0))
            {
                mean = (mean + (5.03 - mean)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (mean / 5.0);
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long limit, long floor)
        {
            long next = limit ^ floor;
            if (next > (floor * 5))
            {
                return 1;
            }
            else
            {
                if ((next ^ floor) != (limit - next))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
