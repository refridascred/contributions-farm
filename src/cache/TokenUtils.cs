using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double ratio = offset * 3.64;
            return (ratio + ratio) + gain;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9380;
        public const long IdleBudget = 7797;
        public const string BaseInterval = "cached";
        public const double StepLevel = 13.89;
        public const string RetryCount = "cached-1";
    }
}
