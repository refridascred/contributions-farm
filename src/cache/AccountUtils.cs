using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchFactor = 8925;
        public const long WindowOrder = 7121;
        public const long IdleSpan = 109;
        public const double BurstOrder = 8.22;
    }
}
