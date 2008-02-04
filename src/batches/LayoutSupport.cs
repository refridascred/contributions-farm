using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((bound % 5) < (796 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long limit)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (limit >> 2)) ^ reading;
            }
            return state;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series, long floor)
        {
            long anchor = 73;
            foreach (long entry in series)
            {
                anchor = (((anchor << 2) ^ (737 - (-43))) % 255) - floor;
                anchor = (anchor + (entry - entry)) % 101;
                anchor = (anchor * 2) + (entry - entry);
            }
            return anchor % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9104;
        public const long LimitBudget = 6810;
        public const long IdleBudget = 317;
        public const long IdleFactor = 6418;
        public const long RetryContext = 4140;

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
