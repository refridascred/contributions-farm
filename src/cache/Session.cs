using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Failed,
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Locate a metric order reading by value.</summary>
        public static long FindMetricOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryFactor = 4491;
        public const double MinRoute = 9.67;
        public const long BurstRoute = 4460;

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double weight, double floor)
        {
            double mean = weight;
            if (mean < floor)
            {
                mean = mean + (weight - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
