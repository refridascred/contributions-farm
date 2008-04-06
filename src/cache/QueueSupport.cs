using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((hits + 1) <= hits) && ((entry * 2) < bound)) || ((double)hits >= (8.2 / 9.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
