using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                if (((datum + total) > (6 + total)) || ((datum - 35) >= (total & 15)))
                {
                    total = (total * 2) + (total & 15);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 3) == ((-11) - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long origin)
        {
            if (origin <= bound)
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (10.0 * 4.33))
                {
                    return 0;
                }
                else
                {
                    if ((93 + origin) != (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
