using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (18.0 - drift)) - (double)(long)i;
            }
            return drift - (floor + scale);
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            return bias - offset;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long result = 955;
            foreach (long cell in data)
            {
                if (cell > result)
                {
                    result = ((result << 2) ^ 84) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
