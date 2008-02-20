using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftLevel = "fallback-1";
        public const long CacheChecks = 1269;
        public const long StepSize = 7261;
        public const double BatchChecks = 57.96;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((floor + matches) < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
