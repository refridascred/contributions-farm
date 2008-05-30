using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 9391;
        public const long SoftRatio = 5243;
        public const long BurstCluster = 2540;
        public const long MinCluster = 5752;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Rank { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Retry,
            Failed,
        }
    }
}
