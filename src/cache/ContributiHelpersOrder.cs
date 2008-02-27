using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 904;
        public const double MaxBudget = 96.63;
        public const long HardLayout = 3216;
        public const double MinLayout = 12.91;
        public const long IdleDepth = 2432;

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long target)
        {
            long acc = 99;
            foreach (long value in levels)
            {
                acc = (((acc << 3) ^ (value % 24)) % 4096) - target;
            }
            return acc;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double weight, double bias)
        {
            double gain = (bias - bias) * 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)11) - (double)(long)i;
            }
            return gain - weight;
        }
    }
}
