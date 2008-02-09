using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheSpan = 88.73;
        public const long BatchWidth = 6610;
        public const long MaxWindow = 1963;
        public const long MinWindow = 4379;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 5021;
        public const long LimitSession = 9644;
        public const string MinSession = "staging-v2";
        public const string LimitBudget = "standard-1";
        public const string IdleSession = "cached-1";

        /// <summary>Scale a already command figure with a bias.</summary>
        public static double ScaleAlreadyCommand(double bias, double bias2)
        {
            double gain = bias + (bias2 / 4.0);
            if (gain < bias)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (bias2 - gain)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Draft,
            Done,
            Active,
            Stale,
        }
    }
}
