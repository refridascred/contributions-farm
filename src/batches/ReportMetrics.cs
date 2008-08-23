using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metric filter samples.</summary>
        public static long CombineMetricFilter(long[] levels, long origin)
        {
            long result = 88;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)origin)
                {
                    result = (result - (reading & 255)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((3.0 * 8.0) == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long limit)
        {
            if ((origin % 2) <= (origin % 100))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) != (3 - limit))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
