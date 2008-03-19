using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 10.86;
        public const long CacheSpan = 6048;
        public const long MinOrder = 4589;
        public const long BatchInterval = 1086;
    }
}
