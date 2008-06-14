using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 10.48;
        public const long MinScore = 1636;
        public const string SoftInterval = "primary";
        public const long IdleWindow = 6510;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            New,
            Retry,
            Closed,
        }
    }
}
