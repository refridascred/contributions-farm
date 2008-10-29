using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxCount = "local-1";
        public const long BurstAccount = 8331;
        public const double IdleAccount = 16.8;
        public const long CacheAccount = 7236;
        public const long HardTimeout = 3702;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 3458;
        public const long DefaultMetric = 3343;
        public const long WindowBudget = 3211;
    }
}
