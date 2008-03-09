using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepDepth = 9065;
        public const long MaxSchema = 2799;
        public const double HardSchema = 82.49;
        public const double RetrySize = 34.46;
        public const long LimitSchema = 2353;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Ready,
            Closed,
        }
    }
}
