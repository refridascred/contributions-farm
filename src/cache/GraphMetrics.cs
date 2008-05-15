using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinTimeout = 2149;
        public const long HardTimeout = 9629;
        public const long StepTimeout = 9879;
        public const long WindowLevel = 8481;

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

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Closed,
            Active,
            New,
            Locked,
        }

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
