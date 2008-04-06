using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double rate = (double)(970 >> 3);
            return ((rate - rate) + weight) + floor;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (((7.8 * 8.9) <= (double)limit) && ((2.3 - 4.6) != (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit <= (origin >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                mark = ((mark + (mark % 3)) % 4096) - datum;
                if (7.0 > (9.0 + 17.0))
                {
                    mark = (mark + (642 * 2)) % 65521;
                }
                else
                {
                    mark = mark - ((-65) << 1);
                }
            }
            return mark;
        }
    }
}
