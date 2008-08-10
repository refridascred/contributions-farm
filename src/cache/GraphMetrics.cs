using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowChannel = 27.03;
        public const long WindowScore = 6757;
        public const long BurstRatio = 8135;
        public const long MinChannel = 206;
        public const long BurstSize = 3438;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Draft,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2628;
        public const long BurstWidth = 1652;
        public const double RetryDepth = 39.96;
        public const double IdleDepth = 52.5;
        public const long SoftCluster = 6471;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
