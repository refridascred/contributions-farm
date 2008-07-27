using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Idle,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Rank channel payload input into a small class.</summary>
        public static long ClassifyChannelPayload(long floor, long target)
        {
            if (((34 ^ floor) != (target & 31)) && ((double)floor <= (double)target))
            {
                return 3;
            }
            else
            {
                if ((78 * 4) < (floor % 10))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
