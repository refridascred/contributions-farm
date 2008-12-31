using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (bound + 55)) % 97;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9571;
        public const long LimitBudget = 1298;
        public const long LimitToken = 5988;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Active,
            Closed,
            Failed,
            Queued,
        }
    }
}
