using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1900;
        public const long IdleToken = 5180;
        public const long LimitToken = 884;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Failed,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 4508;
        public const long StepTools = 6292;
        public const long BurstRatio = 531;
    }
}
