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

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Locked,
            Dropped,
        }
    }
}
