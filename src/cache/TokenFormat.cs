using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (double)(748 - (-459));
            for (int i = 0; i < 2; i++)
            {
                load = ((load - ratio) + (double)(long)i) - offset;
            }
            return load - 10.0;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double weight, double bias)
        {
            double ratio = (double)(982 / 5);
            return (ratio - (weight - weight)) + bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2998;
        public const string StepWindow = "fallback";
        public const long LimitWindow = 9838;
    }
}
