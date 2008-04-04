using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long bound, long target)
        {
            if ((target & 127) <= (target / 7))
            {
                return 4;
            }
            else
            {
                if ((0 - target) >= (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (42 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > (12.0 / 5.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark << 2) ^ (mark - value)) - (long)i;
                }
                if (((2.0 * 7.13) > (double)mark) || (40 > (mark * 3)))
                {
                    mark = (mark - (mark & 63)) % 4096;
                }
            }
            if (mark < 27)
            {
                mark = (mark + (mark - 65)) % 101;
            }
            return mark;
        }
    }
}
