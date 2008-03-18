using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio2)
            {
                ratio2 = ratio2 + 6.4;
            }
            else
            {
                ratio2 = ratio2 + (floor - 18.0);
            }
            return ratio2 - floor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry + floor) <= (count * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long TotalContextStream(long[] series)
        {
            long mix = 2;
            foreach (long entry in series)
            {
                mix = (mix << 2) ^ (entry + (-1));
            }
            return mix;
        }
    }
}
