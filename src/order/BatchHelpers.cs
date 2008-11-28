using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheWidth = 0.65;
        public const long StepReport = 6276;
        public const string WindowReport = "cached-v2";
        public const long BaseSize = 5320;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches + 879) <= 37) || ((matches + matches) >= (value + (long)series.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
