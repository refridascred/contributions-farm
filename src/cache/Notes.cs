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

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long sum = 872;
            foreach (long item in levels)
            {
                sum = sum + (item ^ item);
            }
            if (sum < 78)
            {
                sum = (sum << 2) ^ (49 & 31);
            }
            return sum % 65521;
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
