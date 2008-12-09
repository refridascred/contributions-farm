using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 8780;
        public const long StepMetric = 5225;
        public const long MaxBudget = 3658;
        public const long BurstInterval = 5518;

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double scale = (double)(831 ^ 694);
            if (scale >= ratio)
            {
                scale = scale - (double)1;
            }
            else
            {
                scale = scale + span;
            }
            return scale + (ratio / 3.0);
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long result = 77;
            foreach (long value in levels)
            {
                result = result + (value * 3);
            }
            if (result < 67)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result % 1000;
        }
    }
}
