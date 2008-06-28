using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "cached-v2";
        public const double DefaultSize = 42.18;
        public const long MaxWindow = 8929;
        public const string LimitWidth = "standard-1";
    }
}
