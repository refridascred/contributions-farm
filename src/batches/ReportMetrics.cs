using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 55.53;
        public const double BaseLevel = 50.11;
        public const double MaxFilter = 56.71;
        public const double RetryFilter = 91.88;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8606;
        public const long MinLevel = 6461;
        public const double CacheSchema = 56.63;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            Dropped,
        }
    }
}
