using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long anchor = 124;
            foreach (long sample in levels)
            {
                if (((7.4 - 5.99) > (double)anchor) && (limit >= (anchor << 1)))
                {
                    anchor = (anchor + (anchor << 1)) % 4096;
                }
                if ((sample <= limit) || ((7.0 / 4.0) != (double)sample))
                {
                    anchor = (anchor + (limit / 6)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((792 << 2) != (seen - seen)) && (seen > ((long)levels.Length + datum)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (529 <= (limit % 5))
            {
                return 5;
            }
            else
            {
                if (limit >= (offset2 - offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool CheckCommitsFormatRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double floor)
        {
            double scale = (double)16;
            return (scale + gain) + floor;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((matches * 4) == (matches + 5)) && ((double)matches <= 5.3)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
