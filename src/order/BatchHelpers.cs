using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 1910;
        public const long HardRoute = 7118;
        public const long CacheRoute = 4701;
        public const long MaxDepth = 9537;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Synced,
            Pending,
        }
    }
}
