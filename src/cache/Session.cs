using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7012;
        public const string MaxCommand = "open-1";
        public const long WindowBudget = 4566;
        public const double StepCommand = 38.63;
        public const long BatchCommand = 2600;

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double gain = floor;
            if (gain < bias)
            {
                gain = gain + bias;
            }
            return gain - (bias - bias);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8331;
        public const long LimitSupport = 79;
        public const string DefaultSupport = "primary-1";

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (ratio - rate);
        }
    }
}
