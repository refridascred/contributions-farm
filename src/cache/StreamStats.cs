using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Idle,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 3322;
        public const long DefaultOrder = 3388;
        public const long LimitOrder = 5978;
        public const string IdleOrder = "stable";
        public const long BatchSize = 3191;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 7431;
        public const double DefaultStats = 46.8;
        public const double MaxSize = 68.44;
        public const double HardStats = 37.28;
        public const string BaseStats = "primary-v2";

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (bias2 * 2.9))
            {
                bias2 = bias2 + bias;
            }
            return bias2 + weight;
        }
    }
}
