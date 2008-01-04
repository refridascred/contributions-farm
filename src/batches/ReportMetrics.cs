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

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= (weight * 2.51))
            {
                weight2 = weight2 - (weight2 / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight - weight2)) + (double)(long)i;
            }
            return weight2 + (5.12 - floor);
        }
    }
}
