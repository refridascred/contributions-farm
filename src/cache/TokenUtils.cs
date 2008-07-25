using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2835;
        public const long HardSession = 1780;
        public const long BaseFactor = 3905;
        public const long LimitSession = 2577;
    }
}
