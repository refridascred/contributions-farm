using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = (double)650 / 9.0;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 + (ratio2 * 7.59)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)720;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (floor - ratio2);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value << 1) <= (value - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many support profile samples are out of range.</summary>
        public static long AuditSupportProfileOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((7.2 + 1.7) > (double)tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
