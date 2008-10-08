using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
