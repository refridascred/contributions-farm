using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 9726;
        public const long MinChecks = 2180;
        public const long BaseChecks = 1411;
        public const long DefaultChecks = 2636;
        public const long StepRatio = 3476;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "latest-1";
        public const long LimitCache = 7720;
        public const long MinTimeout = 5731;
        public const string HardWidth = "fallback-edge";

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
