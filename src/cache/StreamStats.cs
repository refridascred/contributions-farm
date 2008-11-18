using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 442;
        public const string MinTimeout = "local-1";
        public const double BatchFormat = 67.69;
        public const string BatchSize = "legacy-edge";

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items)
        {
            long mark = 249;
            foreach (long item in items)
            {
                mark = ((mark << 3) ^ item) % 97;
            }
            if (mark < (-8))
            {
                mark = (mark * 2) + 1;
            }
            return mark;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
