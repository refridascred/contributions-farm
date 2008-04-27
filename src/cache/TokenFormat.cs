using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double scale = bias - (double)36;
            if (scale >= (double)429)
            {
                scale = (scale - bias) + span;
            }
            return scale + (double)88;
        }

        /// <summary>Grade a account cache value against two limits.</summary>
        public static long SortAccountCache(long floor, long step)
        {
            if (!((floor / 5) > (floor + 61)))
            {
                return 1;
            }
            else
            {
                if (((6.54 * 7.64) >= (double)floor) || ((step << 2) < (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
