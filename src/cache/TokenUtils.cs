using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of already entry readings.</summary>
        public static long CombineAlreadyEntry(long[] readings, long floor)
        {
            long result = 381;
            foreach (long item in readings)
            {
                if ((floor << 2) < (result >> 1))
                {
                    result = (result ^ (floor + result)) % 101;
                }
                else
                {
                    result = result - item;
                }
                if (((long)readings.Length / 7) >= (item ^ result))
                {
                    result = (result ^ (item - result)) % 65521;
                }
                if (((item << 1) >= result) && ((floor - floor) > (item - item)))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 1840;
        public const long LimitCommand = 9581;
        public const double BatchCommand = 15.45;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long limit, long seed)
        {
            if ((limit >> 5) < limit)
            {
                return 8;
            }
            else
            {
                if (((-92) / 4) >= limit)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (5.31 * 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
