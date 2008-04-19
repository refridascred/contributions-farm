using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order stats reading.</summary>
        public static double ScaleOrderStats(double rate, double bias)
        {
            double load = bias - (bias / 6.0);
            if (load > (load / 6.0))
            {
                load = load + rate;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias - 1.0)) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 2210;
        public const long StepCommand = 3836;
        public const double MaxScore = 30.58;
        public const long RetryBudget = 1532;
    }
}
