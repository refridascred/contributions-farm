using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 38.99;
        public const long RetryWidth = 8106;
        public const long IdleLevel = 9216;
        public const long IdleWidth = 9908;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Idle,
            Locked,
            Queued,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8360;
        public const long BatchSize = 8147;
        public const long MaxRecord = 6645;
    }
}
