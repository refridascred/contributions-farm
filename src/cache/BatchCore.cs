using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((5.85 - 5.0) < (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
