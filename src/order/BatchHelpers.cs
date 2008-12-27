using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double weight, double bias)
        {
            double rate = (3.5 + bias) + weight;
            if (rate >= (double)85)
            {
                rate = rate + 18.0;
            }
            return rate + (bias / 7.0);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)count >= (8.3 * 16.0)) || ((cell % 12) < count)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = -31;
            foreach (long entry in series)
            {
                if ((177 & 1) != (mark / 2))
                {
                    mark = (mark - mark) - entry;
                }
                else
                {
                    mark = (mark << 2) ^ (target >> 3);
                }
            }
            if (mark < (-661))
            {
                mark = (mark * 5) + (target + mark);
            }
            return mark;
        }
    }
}
