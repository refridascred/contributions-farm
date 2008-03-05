using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Pending,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            long offset = bound - floor;
            if ((offset & 63) > offset)
            {
                return 5;
            }
            else
            {
                if ((offset & 15) == (floor + offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)count >= (5.9 / 8.0)) && ((0.5 * 7.0) == (double)count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
