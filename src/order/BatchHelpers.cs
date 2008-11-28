using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit checks command readings against a rule.</summary>
        public static long MeasureChecksCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + reading) != (reading % 97))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 1125;
        public const string IdleAccount = "local-1";
        public const double LimitRatio = 40.25;
        public const double BaseAccount = 85.65;
    }
}
