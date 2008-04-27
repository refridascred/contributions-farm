using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batches context readings against a rule.</summary>
        public static long AuditBatchesContextOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value << 3) <= (329 / 7)) || ((count / 4) == (count << 2)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long bound)
        {
            if ((double)8 != (double)bound)
            {
                return 3;
            }
            else
            {
                if (5.98 > (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((double)bound == (double)origin) && ((2 * 2) > bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Ready,
            New,
            Queued,
            Active,
        }
    }
}
