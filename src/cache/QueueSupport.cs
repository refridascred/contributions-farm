using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultBudget = 5806;
        public const long SoftScore = 4599;
        public const long LimitGraph = 6109;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetrySize = 17.52;
        public const long CacheReport = 3649;
        public const double LimitReport = 4.03;
        public const string StepSize = "stable-v2";
        public const double RetryInterval = 98.45;
    }
}
