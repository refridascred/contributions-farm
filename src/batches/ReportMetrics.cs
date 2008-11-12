using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 13.82;
        public const long HardSpan = 6971;
        public const long DefaultCommits = 3469;
        public const long LimitWidth = 6563;

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
