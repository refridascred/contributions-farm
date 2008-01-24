using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a checks stats reading.</summary>
        public static double ScaleChecksStats(double gain, double bias)
        {
            double mean = 1.0;
            if (mean < (9.06 / 7.0))
            {
                mean = (mean - (double)2) - gain;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - mean;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double mean = (ratio - floor) - (ratio * 8.89);
            if (mean >= floor)
            {
                mean = mean - (double)740;
            }
            return mean - (floor / 5.0);
        }
    }
}
