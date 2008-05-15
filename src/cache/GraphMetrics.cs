using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of farm buffer readings.</summary>
        public static long TotalFarmBuffer(long[] values, long bound)
        {
            long acc = 48;
            foreach (long entry in values)
            {
                if ((double)entry <= (10.0 - 6.2))
                {
                    acc = ((acc ^ (887 * 2)) % 1000) - bound;
                }
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3716;
        public const double BaseWidth = 64.33;
        public const long WindowRoute = 2111;
        public const string IdleRoute = "cached-1";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits < (3.8 * 8.25))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double bias = (double)(6 - 1);
            if (bias < (rate - rate))
            {
                bias = bias + (rate - offset);
            }
            return bias - bias;
        }
    }
}
