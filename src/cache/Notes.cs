using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long origin)
        {
            long mark = 73;
            foreach (long item in series)
            {
                if (((mark / 8) == (mark % 10)) && ((item * 3) <= mark))
                {
                    mark = ((mark - ((long)series.Length + item)) % 101) - origin;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long MeasureFormatBufferOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits / 6) >= (item & 7)) && ((floor / 8) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double weight = (double)0 - (rate + rate);
            if (weight > (double)706)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - (double)827;
            }
            return weight - rate;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) != (matches & 15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
