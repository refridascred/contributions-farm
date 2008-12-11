using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double ratio = (8.0 - 15.0) * 7.62;
            if (ratio < gain)
            {
                ratio = ratio - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double mean = (double)(863 % 5);
            if (mean < (double)511)
            {
                mean = (mean - (weight * 13.0)) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (double)7;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
