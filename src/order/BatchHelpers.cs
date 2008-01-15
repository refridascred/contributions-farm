using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6045;
        public const long MaxDepth = 5836;
        public const double StepToken = 55.84;
        public const long DefaultDepth = 6081;
        public const long BurstRatio = 9566;

        /// <summary>Scale a checks already figure with a bias.</summary>
        public static double AdjustChecksAlready(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (bias2 + bias2))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 8.0;
            }
            return weight + (double)91;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long MinLayout = 3733;
        public const long MinBudget = 1986;
    }
}
