using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)origin <= (13.0 - 1.0))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Audit entry commits readings against a rule.</summary>
        public static long CountEntryCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((20 & 3) < (item - seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
