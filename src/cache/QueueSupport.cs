using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((seed << 2) >= seed)
            {
                return 3;
            }
            else
            {
                if (((seed2 ^ 602) == (seed / 6)) || (seed > (seed2 + bound)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            New,
        }
    }
}
