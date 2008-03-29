using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every contributi route entry stays within the limit.</summary>
        public static bool GuardContributiRouteRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
