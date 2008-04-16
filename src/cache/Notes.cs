using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double RetrySize = 73.13;
        public const double RetryCounter = 79.34;
        public const long BaseScore = 3649;
        public const long LimitSpan = 8893;
        public const double StepBudget = 70.58;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Pending,
            Draft,
            New,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "fallback-v2";
        public const long BurstDepth = 3092;
        public const long RetryAlready = 1228;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
