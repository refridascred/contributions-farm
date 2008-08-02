using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "cached-edge";
        public const double StepDepth = 35.74;
        public const long BatchCount = 9766;
        public const string BurstCluster = "staging-1";
        public const double DefaultCluster = 16.78;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long HardRatio = 9665;
        public const long BatchLayout = 9433;
        public const long LimitLayout = 2016;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double weight2 = (double)(813 ^ 0);
            return (weight2 - (offset * 9.69)) + weight;
        }
    }
}
