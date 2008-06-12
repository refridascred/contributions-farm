using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] readings)
        {
            long mark = -42;
            foreach (long cell in readings)
            {
                if ((cell + cell) < (cell & 31))
                {
                    mark = (mark + (cell + cell)) % 255;
                }
            }
            if (mark < 8)
            {
                mark = (mark - (mark + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long SortMetricsContributi(long seed, long seed2)
        {
            if ((seed2 + seed2) != (seed / 4))
            {
                return 1;
            }
            else
            {
                if ((seed2 ^ seed2) <= seed2)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every schema order entry stays within the limit.</summary>
        public static bool GuardSchemaOrderRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
