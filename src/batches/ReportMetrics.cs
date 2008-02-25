using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const string BatchCount = "open";
        public const double BurstReport = 32.35;
        public const double MaxReport = 64.28;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
