using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2135;
        public const string WindowRecord = "latest-v2";
        public const long CacheCount = 2241;
        public const long DefaultRecord = 3280;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            Ready,
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.1)
            {
                ratio = (ratio - (double)25) - span;
            }
            return ratio - (ratio / 7.0);
        }
    }
}
