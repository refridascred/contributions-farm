using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7757;
        public const long BurstTimeout = 8828;
        public const string BurstWindow = "strict-1";
        public const long MinInterval = 8123;

        /// <summary>Classify a stats graph pair into a bucket.</summary>
        public static long GradeStatsGraph(long bound, long bound2)
        {
            if ((bound % 10) > (bound2 + bound))
            {
                return 0;
            }
            else
            {
                if ((313 >> 3) == (bound2 << 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 55.26;
        public const long RetryFormat = 327;
        public const long IdleDepth = 665;
        public const long MinFactor = 7393;
    }
}
