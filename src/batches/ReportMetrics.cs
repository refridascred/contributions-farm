using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double weight = bias - 18.0;
            if (weight > weight)
            {
                weight = (weight + (weight - 3.0)) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (bias / 2.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 9454;
        public const long MinDepth = 1461;
        public const long IdleStats = 1711;
        public const long SoftBudget = 1729;
        public const long SoftStats = 4831;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((-70) > hits)
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
