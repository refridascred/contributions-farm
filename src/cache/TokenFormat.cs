using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "standard-edge";
        public const double MaxScore = 23.56;
        public const string CacheRoute = "fallback";
        public const long MinRoute = 8479;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
