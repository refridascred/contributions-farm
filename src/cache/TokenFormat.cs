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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(3 < reading) || ((hits ^ 972) <= (hits & 31)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
