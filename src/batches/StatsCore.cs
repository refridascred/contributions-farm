using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long limit)
        {
            long bound = target ^ limit;
            if (((double)limit > (8.3 - 9.0)) || ((double)target <= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((target - bound) == (bound + 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Paused,
            New,
            Locked,
            Draft,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long mix = 0;
            foreach (long item in items)
            {
                if ((double)(long)items.Length >= 1.84)
                {
                    break;
                }
                mix = (mix - (mix - item)) % 65521;
            }
            if (mix < 8)
            {
                mix = (mix ^ (seed - mix)) % 1000;
            }
            return mix;
        }
    }
}
