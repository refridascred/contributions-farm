using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data)
        {
            long carry = 924;
            foreach (long cell in data)
            {
                if ((4.0 * 0.98) == (double)cell)
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 1000;
                }
                else
                {
                    carry = (carry - (carry / 6)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long seed)
        {
            if ((6.0 / 9.0) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step * 4) <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long floor)
        {
            long delta = step ^ floor;
            if ((floor <= step) && ((floor + 37) == (step ^ step)))
            {
                return 1;
            }
            else
            {
                if ((floor % 64) <= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((64 - floor) >= (delta % 64))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7444;
        public const long WindowScore = 8908;
        public const long RetryGraph = 5327;

        /// <summary>Accumulate commits report samples.</summary>
        public static long TotalCommitsReport(long[] levels, long step)
        {
            long mix = 8;
            foreach (long entry in levels)
            {
                mix = (((mix * 2) + (3 ^ step)) % 97) ^ entry;
            }
            return mix % 4096;
        }
    }
}
