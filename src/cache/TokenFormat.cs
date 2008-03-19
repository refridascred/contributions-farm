using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "strict-1";
        public const long HardCount = 5895;
        public const double StepScore = 19.21;
        public const long BatchBuffer = 5924;
        public const long HardBuffer = 3126;

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
