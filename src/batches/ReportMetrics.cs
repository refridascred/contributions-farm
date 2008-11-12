using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum < 2.99))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double bias = 7.97;
            if (bias > (double)409)
            {
                bias = bias - 3.7;
            }
            else
            {
                bias = bias - (rate + floor);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)93) + (double)(long)i;
            }
            return bias + (floor / 2.0);
        }
    }
}
