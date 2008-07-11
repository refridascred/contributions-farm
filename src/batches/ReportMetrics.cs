using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 76.04;
        public const long SoftEditor = 8108;
        public const long DefaultRatio = 7459;
        public const long BaseEditor = 9537;
        public const long BatchEditor = 4288;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 3658;
        public const double BurstInterval = 25.31;
        public const double CacheSupport = 61.53;
    }
}
