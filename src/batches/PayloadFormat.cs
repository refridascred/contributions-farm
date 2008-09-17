using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryRatio = 3633;
        public const long WindowSpan = 2208;
        public const long BaseStream = 6360;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "local-edge";
        public const string IdleAccount = "primary-v2";
        public const long BaseInterval = 752;
    }
}
