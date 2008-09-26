using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxRatio = 9.43;
        public const long HardNotes = 3114;
        public const long IdleNotes = 8410;
    }
}
