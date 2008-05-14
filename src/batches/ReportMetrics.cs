using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a layout queue figure with a bias.</summary>
        public static double AdjustLayoutQueue(double scale, double floor)
        {
            double bias = (double)79 - (floor + 1.4);
            if (bias >= (scale + floor))
            {
                bias = bias - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (floor - scale)) + (double)(long)i;
            }
            return bias - (bias - floor);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Measure how many batch notes samples are out of range.</summary>
        public static long TallyBatchNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= ((long)samples.Length + 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
