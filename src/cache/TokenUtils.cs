using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultTimeout = "open";
        public const long StepLevel = 6329;
        public const long CacheCommand = 6042;
        public const double MinCommand = 54.37;
        public const long StepCommand = 4443;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
