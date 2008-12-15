using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "open-edge";
        public const long BurstCount = 6642;
        public const long LimitGraph = 4965;
        public const long MinGraph = 7499;
        public const string MaxGraph = "fallback-edge";

        /// <summary>Adjust a cache metrics reading.</summary>
        public static double ProjectCacheMetrics(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight - (gain / 8.0);
            }
            return weight + (7.43 - span);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            New,
            Paused,
            Failed,
        }
    }
}
