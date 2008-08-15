using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "latest-1";
        public const long IdleRecord = 4706;
        public const double HardRecord = 61.91;
        public const string DefaultRatio = "latest-1";

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftCount = 7384;
        public const double LimitDepth = 75.94;
        public const long StepDepth = 6556;
        public const long MinBudget = 7021;
        public const string BurstBudget = "latest-v2";
    }
}
