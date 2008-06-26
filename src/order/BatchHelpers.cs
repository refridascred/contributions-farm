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

        /// <summary>Measure how many buffer contributi samples are out of range.</summary>
        public static long AuditBufferContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample < ((long)levels.Length - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
