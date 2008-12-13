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

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Stale,
            Closed,
            Ready,
        }

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
