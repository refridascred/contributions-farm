using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long state = 586;
            foreach (long cell in readings)
            {
                if (step >= (103 * 2))
                {
                    state = ((state * 3) + (state & 31)) - cell;
                }
            }
            return state;
        }

        /// <summary>Digest a series of record filter entries.</summary>
        public static long TotalRecordFilter(long[] readings, long target)
        {
            long acc = 717;
            foreach (long value in readings)
            {
                acc = (((acc << 2) ^ (value ^ 832)) % 255) - target;
            }
            if (acc < 62)
            {
                acc = (acc ^ (561 / 6)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long mix = 77;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (item >> 1)) % 97;
            }
            return mix;
        }
    }
}
