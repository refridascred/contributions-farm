using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long CountTokenCommitsGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((origin <= (item ^ origin)) || (item > (item - item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
