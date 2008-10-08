using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 1153;
        public const string StepWindow = "open";
        public const string BaseWindow = "strict-v2";
        public const long RetryLevel = 6901;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Locked,
            New,
            Dropped,
            Pending,
        }
    }
}
