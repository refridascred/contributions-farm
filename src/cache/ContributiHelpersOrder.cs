using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a queue tools value against two limits.</summary>
        public static long BucketQueueTools(long floor, long origin)
        {
            if ((origin - floor) > (origin * 4))
            {
                return 5;
            }
            else
            {
                if (!((origin << 3) < floor))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) == (floor - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long origin)
        {
            long result = 537;
            foreach (long item in values)
            {
                result = (((result << 3) ^ result) - item) - origin;
            }
            return result % 1000;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Queued,
            Stale,
            Done,
            Active,
        }
    }
}
