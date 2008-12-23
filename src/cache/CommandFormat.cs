using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double scale, double bias)
        {
            double rate = 17.0 + (double)843;
            if (rate > (8.1 / 3.0))
            {
                rate = (rate + bias) - scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate - (rate - bias);
        }

        /// <summary>Look up the position of a format token sample.</summary>
        public static long LocateFormatTokenIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 3) + (seed << 2);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long offset)
        {
            long diff = floor + offset;
            if (!((floor / 7) != ((-136) + offset)))
            {
                return 1;
            }
            else
            {
                if (diff <= (diff ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (6.33 - 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
