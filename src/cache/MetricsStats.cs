using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict-1";
        public const long MinTimeout = 2114;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 71.07;
        public const long RetryBuffer = 8073;
        public const long BurstBuffer = 9508;
        public const string RetryFactor = "primary";
        public const long BatchBuffer = 5265;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2198;
        public const double IdleSize = 29.18;
        public const long BaseCluster = 1030;
        public const long MinCluster = 781;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 71.47;
        public const long HardRatio = 5823;
        public const string LimitAccount = "fallback-edge";
        public const long LimitScore = 5936;
        public const long RetryAccount = 2639;
    }
}
