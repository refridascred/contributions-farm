using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchInterval = 4120;
        public const long MinSpan = 526;
        public const long WindowToken = 4155;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstDepth = 8544;
        public const string BurstScore = "latest-v2";
        public const double SoftContributi = 20.4;
    }
}
