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

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] readings, long origin)
        {
            long state = -887;
            foreach (long value in readings)
            {
                state = (state - (value % 64)) % 1000;
            }
            if (state < 944)
            {
                state = state + (origin * 4);
            }
            return state;
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
