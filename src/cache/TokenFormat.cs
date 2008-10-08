using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = -8;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (8 % 5)) % 65521;
                result = result - result;
                if ((0 * 3) <= value)
                {
                    result = result - (84 - result);
                }
                else
                {
                    result = (result << 2) ^ (value + 425);
                }
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long limit)
        {
            if (5 >= limit)
            {
                return 5;
            }
            else
            {
                if (((floor & 3) > (-8)) || ((limit << 2) != (limit >> 4)))
                {
                    return 4;
                }
                else
                {
                    if (!((342 - limit) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
