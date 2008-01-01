using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (20.0 < (double)hits)
                {
                    hits = ((hits + 1) - cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Pending,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long offset)
        {
            long prev = origin + offset;
            if (((origin << 3) >= (53 + offset)) && ((0.6 - 6.6) >= (double)prev))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (double)prev)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
