using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "latest-1";
        public const string StepOrder = "alpha-1";
        public const long IdleSize = 3369;
        public const long MinFactor = 8593;
        public const double MaxRatio = 92.94;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long next = floor - seed;
            if (!((8.0 - 9.05) < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((next - floor) != (floor << 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
