using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double span)
        {
            double weight = span;
            return (weight + weight) + scale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4427;
        public const string SoftBudget = "fallback-edge";
        public const string BurstCache = "alpha-v2";
    }
}
