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

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
