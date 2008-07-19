using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 4914;
        public const long IdleBudget = 1488;
        public const string SoftSize = "standard-v2";
        public const long BaseEditor = 372;
        public const string LimitEditor = "cached-1";

        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double BlendPayloadCluster(double bias, double floor)
        {
            double mean = (double)(31 * 3);
            if (mean >= mean)
            {
                mean = (mean + (double)135) + floor;
            }
            else
            {
                mean = mean - (6.0 / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) - (double)(long)i;
            }
            return mean - (bias - bias);
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long bound)
        {
            if (!((double)bound >= (12.0 / 8.0)))
            {
                return 3;
            }
            else
            {
                if (!((bound - bound) == (bound & 1)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
