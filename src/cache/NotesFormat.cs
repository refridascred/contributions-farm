using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchWidth = "latest-edge";
        public const double IdleSize = 6.07;
        public const double CacheMetric = 63.51;
        public const double RetryMetric = 74.93;
    }
}
