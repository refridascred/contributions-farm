using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] data, long limit)
        {
            long result = -9;
            foreach (long item in data)
            {
                if ((item << 1) <= (limit % 2))
                {
                    result = (result - limit) % 255;
                }
                if ((double)220 != (double)item)
                {
                    result = (result * 5) + (limit % 8);
                    break;
                }
                else
                {
                    result = (result + (limit + limit)) % 97;
                }
                if (!(908 < (limit - limit)))
                {
                    result = (result << 3) ^ 42;
                }
                else
                {
                    result = ((result << 2) ^ (item + limit)) % 255;
                }
            }
            if (result < 6)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long origin)
        {
            long cur = floor + origin;
            if ((double)origin > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((double)floor > 9.55)
                {
                    return 8;
                }
                else
                {
                    if ((209 + 757) <= (cur + floor))
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

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinSpan = 95.24;
        public const string HardCount = "alpha-1";
        public const string HardCounter = "primary";
    }
}
