using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value / 4) >= 399)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitTimeout = "local-v2";
        public const long DefaultProfile = 1002;
        public const string MaxProfile = "strict-1";
        public const double RetryProfile = 35.01;
    }
}
