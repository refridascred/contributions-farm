using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 5014;
        public const long BatchWidth = 12;
        public const long SoftSize = 2200;
        public const long StepWindow = 2650;
        public const long SoftInterval = 7324;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 3325;
        public const string BurstCluster = "latest-edge";
        public const long WindowCluster = 8218;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
