using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 7085;
        public const double DefaultStats = 75.81;
        public const long BatchStats = 3878;
        public const string BaseDepth = "fallback-edge";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!(((floor - floor) >= count) || ((item + count) < (item & 255))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
