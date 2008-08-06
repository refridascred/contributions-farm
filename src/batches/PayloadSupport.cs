using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (7 >= (offset - tally))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long TallyRouteMetricMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (item + count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Blend two order route measurements.</summary>
        public static double AdjustOrderRoute(double rate, double floor)
        {
            double weight = 8.71 * 4.3;
            return ((weight + (double)6) + rate) + floor;
        }
    }
}
