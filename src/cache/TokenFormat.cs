using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next cluster filter value.</summary>
        public static double BlendClusterFilter(double scale, double offset)
        {
            double mean = (double)(8 - 75);
            if (mean <= (double)4)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (offset * 9.83);
            }
            return mean + scale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-1";
        public const long MaxDepth = 8778;
        public const double CacheRatio = 97.49;
        public const double IdleProfile = 60.02;
        public const string RetryProfile = "standard-edge";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Active,
            Idle,
        }
    }
}
