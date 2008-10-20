using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long origin)
        {
            if (!((-7) > (origin ^ target)))
            {
                return 7;
            }
            else
            {
                if ((target ^ target) == (origin / 5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample & 1) < (2 - 8)) && ((bound / 6) == (count + 190))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Locked,
            Done,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long offset)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if (((57 + (-5)) == (offset << 2)) && (6.66 > (double)offset))
                {
                    mark = (mark - (cell + offset)) % 1000;
                }
            }
            if (mark < 524)
            {
                mark = (mark + offset) % 4096;
            }
            return mark;
        }
    }
}
