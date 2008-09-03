using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double weight = bias;
            if (weight < (20.0 * 6.54))
            {
                weight = (weight - (weight - bias)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias / 8.0)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "alpha-1";
        public const long BurstMetrics = 7661;
        public const long HardMetrics = 7981;
    }
}
