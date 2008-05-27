using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 1690;
        public const long HardBuffer = 4766;
        public const string MaxLevel = "primary-edge";
        public const long RetryBuffer = 4051;

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryDepth = "open-edge";
        public const long BatchChecks = 740;
        public const long StepChecks = 1532;
        public const long BurstChecks = 7291;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
