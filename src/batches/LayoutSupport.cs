using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 8.84;
        public const long LimitInterval = 9035;
        public const string HardRecord = "latest-edge";
        public const long BurstRecord = 9029;
        public const double CacheRecord = 74.43;

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Locked,
            Done,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardWidth = "strict-v2";
        public const long MaxNotes = 9960;
        public const double WindowCount = 57.3;
        public const double CacheSpan = 55.42;

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 33.89;
        public const double LimitBudget = 82.46;
        public const double BaseTimeout = 49.29;
        public const double SoftQueue = 81.55;
        public const string BurstBudget = "fallback-edge";
    }
}
