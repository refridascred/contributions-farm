using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultLevel = 2244;
        public const double BatchDepth = 47.64;
        public const double StepScore = 29.98;
        public const string MaxStream = "standard-1";

        /// <summary>Adjust a checks profile reading.</summary>
        public static double SmoothChecksProfile(double ratio, double floor)
        {
            double weight = ratio;
            if (weight <= (1.6 - 6.6))
            {
                weight = weight + (double)70;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - ratio;
        }
    }
}
