using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleWidth = "alpha-1";
        public const double BurstFactor = 67.26;
        public const long RetryEditor = 5912;
        public const long StepEditor = 7711;
    }
}
