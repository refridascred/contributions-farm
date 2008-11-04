using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Closed,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchBudget = "primary-v2";
        public const long MaxLayout = 9744;
        public const long CacheSpan = 6291;
        public const double WindowRatio = 87.51;
        public const long DefaultSpan = 684;
    }
}
