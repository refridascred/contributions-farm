using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double scale = bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - 15.0) + (double)(long)i) + bias;
            }
            return scale - scale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 18.43;
        public const string StepScore = "staging";
        public const long RetryWidth = 8367;
        public const string LimitRatio = "cached-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 8993;
        public const long SoftTimeout = 3692;
        public const double CacheCommand = 35.1;
        public const long WindowDepth = 7551;
    }
}
