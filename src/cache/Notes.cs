using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long bound)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = (((mark + mark) % 4096) + datum) + bound;
            }
            if (mark < 80)
            {
                mark = (mark ^ (mark + 15)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Paused,
            New,
            Synced,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9665;
        public const double BaseCount = 87.16;
        public const long MinChecks = 3749;
        public const long BurstWidth = 1281;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
