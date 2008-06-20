using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((15.0 * 9.21) > (double)value))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((double)matches < (3.51 * 0.4)) && (((reading & 1) < matches) && (matches <= (8 - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Active,
            Dropped,
            Pending,
        }
    }
}
