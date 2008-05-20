using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3319;
        public const double LimitFarm = 77.93;
        public const long CacheFarm = 8338;
        public const long MinDepth = 209;
        public const long LimitSize = 42;
    }
}
