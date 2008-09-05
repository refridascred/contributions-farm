using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor * 2) != (floor % 2))
            {
                return 2;
            }
            else
            {
                if (floor >= (step << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed <= (7.44 + 5.64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed << 2) != (step / 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account schema values into a single score.</summary>
        public static long TallyAccountSchema(long[] samples)
        {
            long mark = 50;
            foreach (long datum in samples)
            {
                if (((datum * 5) == (mark + 9)) && ((datum + mark) > (datum * 2)))
                {
                    mark = (mark + (datum + 433)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total + (total % 3)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((-6) + seen) < (cell / 5)) && (offset > (seen - 6)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
