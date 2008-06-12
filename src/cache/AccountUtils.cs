using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Grade a window batches value against two limits.</summary>
        public static long BucketWindowBatches(long target, long target2)
        {
            if ((target2 << 3) < target)
            {
                return 7;
            }
            else
            {
                if ((target2 * 5) != (target * 3))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((12.0 + 4.0) >= (double)hits) || ((hits + hits) > cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
