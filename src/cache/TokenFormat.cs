using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cache already readings against a bound.</summary>
        public static bool CheckCacheAlreadyRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long FoldRecordRoute(long[] readings)
        {
            long state = 9;
            foreach (long datum in readings)
            {
                if (!(((9.1 * 15.0) <= (double)state) || ((2 + state) != (state ^ state))))
                {
                    state = ((state * 5) + (927 * 3)) + datum;
                }
                state = ((state << 2) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
