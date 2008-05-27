using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 76.28;
        public const long LimitLevel = 4438;
        public const long RetryWidth = 544;
        public const long BurstNotes = 4791;
        public const long BaseNotes = 208;
    }
}
