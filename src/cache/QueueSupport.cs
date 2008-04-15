using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Closed,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long offset)
        {
            long slot = target - offset;
            if (offset >= (target * 4))
            {
                return 5;
            }
            else
            {
                if (offset <= (slot * 2))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
