using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheSpan = 43.47;
        public const long StepStream = 9169;
        public const string LimitStream = "primary-1";
        public const long IdleBudget = 6673;
        public const long RetryDepth = 6823;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
