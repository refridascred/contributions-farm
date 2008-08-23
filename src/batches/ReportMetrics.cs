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

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = (double)(951 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 - (double)(long)i) + ratio) + span;
            }
            return ratio2 - ratio2;
        }
    }
}
