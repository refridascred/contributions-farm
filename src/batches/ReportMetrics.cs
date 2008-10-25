using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double mean = 20.0 - (double)8;
            if (mean >= span)
            {
                mean = (mean + (double)2) + gain;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean + (double)8;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double gain = ratio;
            if (gain >= (4.78 / 9.0))
            {
                gain = (gain - (1.1 * 2.0)) - bias;
            }
            return gain - (gain / 8.0);
        }
    }
}
