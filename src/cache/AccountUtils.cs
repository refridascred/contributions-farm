using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitWidth = 5713;
        public const long CacheRatio = 6768;
        public const double SoftCommits = 84.35;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8077;
        public const long SoftSize = 158;
        public const long CacheContext = 84;
    }
}
