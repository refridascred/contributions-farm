using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Active,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback";
        public const long LimitSize = 8134;
        public const long CacheTimeout = 231;
        public const double DefaultSession = 77.93;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8699;
        public const string HardToken = "cached-1";
        public const long DefaultSpan = 793;
        public const long BaseDepth = 1591;
        public const long IdleToken = 8282;
    }
}
