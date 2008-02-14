using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long offset)
        {
            if ((floor / 9) > (floor - 802))
            {
                return 5;
            }
            else
            {
                if (!((6.19 + 5.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry channel value.</summary>
        public static double ScaleEntryChannel(double scale, double bias)
        {
            double weight = (double)306 - (7.0 * 9.7);
            if (weight < (scale / 5.0))
            {
                weight = weight - (bias + scale);
            }
            else
            {
                weight = weight - 2.5;
            }
            return weight - (double)8;
        }
    }
}
