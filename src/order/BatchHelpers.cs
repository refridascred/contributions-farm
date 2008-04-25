using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (2.15 < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5918;
        public const long DefaultTimeout = 1545;
        public const long BatchBudget = 1659;
        public const long DefaultWidth = 4219;
    }
}
