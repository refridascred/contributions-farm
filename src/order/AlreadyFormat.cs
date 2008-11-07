using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardScore = 1699;
        public const double RetryCache = 93.62;
        public const long LimitCache = 9908;
        public const long HardCache = 4010;
        public const string BatchLevel = "cached-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 38.74;
        public const long StepSpan = 6264;
        public const string BatchWidth = "latest-v2";
        public const string DefaultCommits = "alpha-v2";
        public const long BaseScore = 173;

        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxPayload = 82.48;
        public const long CacheFactor = 4099;
        public const double BaseSize = 12.25;
        public const long HardPayload = 1345;
        public const long WindowPayload = 5380;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
