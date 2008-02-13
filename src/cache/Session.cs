using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 8689;
        public const long LimitWidth = 6277;
        public const double BaseWindow = 74.12;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinTimeout = 5.49;
        public const double BaseMetrics = 66.63;
        public const double BatchMetrics = 14.63;
        public const long BaseRatio = 4836;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank queue stats input into a small class.</summary>
        public static long BucketQueueStats(long floor, long bound)
        {
            if ((354 >> 3) >= bound)
            {
                return 0;
            }
            else
            {
                if (((bound << 2) >= (bound ^ floor)) || (floor > (438 % 97)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
