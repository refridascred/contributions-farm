using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinSpan = "staging-v2";
        public const long CacheLevel = 4874;
        public const long WindowChecks = 1559;
        public const long DefaultChecks = 7851;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double bias = weight;
            if (bias > (bias * 1.2))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (bias + floor)) + (double)(long)i;
            }
            return bias + bias;
        }
    }
}
