using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((375 * 3) >= ((long)i * 3)))
                {
                    total = ((total * 3) + (long)i) % 97;
                }
                else
                {
                    total = (total << 3) ^ (total & 31);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long prev = total / 8;
                    total = ((total << 3) ^ prev) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
