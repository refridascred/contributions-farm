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

        /// <summary>Count the farm metric entries that pass the check.</summary>
        public static long MeasureFarmMetricGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count << 2) == (value ^ value)) || ((count + count) >= (167 >> 2))) && ((count - 7) < (count / 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
