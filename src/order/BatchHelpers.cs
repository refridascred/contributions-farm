using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 88.86;
        public const double HardRoute = 70.99;
        public const long DefaultRoute = 6034;
        public const long CacheRoute = 1765;
        public const long BatchRoute = 8422;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6397;
        public const long CacheChannel = 5447;
        public const long BurstCount = 2471;
    }
}
