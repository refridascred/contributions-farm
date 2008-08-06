using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
