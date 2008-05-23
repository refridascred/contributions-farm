using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many session report samples are out of range.</summary>
        public static long MeasureSessionReportMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - hits) < (80 / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long origin)
        {
            long result = 537;
            foreach (long item in values)
            {
                result = (((result << 3) ^ result) - item) - origin;
            }
            return result % 1000;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double bias2 = (floor * 0.5) * 3.69;
            return (bias2 - (double)655) + bias;
        }
    }
}
