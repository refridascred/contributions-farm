using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double floor)
        {
            double ratio2 = 0.6;
            if (ratio2 <= (ratio - ratio))
            {
                ratio2 = (ratio2 - ratio2) + floor;
            }
            else
            {
                ratio2 = ratio2 - (double)31;
            }
            return ratio2 + (ratio * 3.07);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((431 + reading) < (-159))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
