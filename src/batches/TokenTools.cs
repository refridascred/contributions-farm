using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "fallback-v2";
        public const long MaxScore = 65;
        public const long MinDepth = 1813;
        public const long WindowBudget = 2257;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double drift = gain;
            if (drift > gain)
            {
                drift = drift - (drift / 7.0);
            }
            return drift - span;
        }
    }
}
