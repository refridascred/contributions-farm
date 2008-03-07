using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 695;
        public const string IdleFactor = "fallback";
        public const long LimitAccount = 8089;
        public const long RetryDepth = 9943;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
