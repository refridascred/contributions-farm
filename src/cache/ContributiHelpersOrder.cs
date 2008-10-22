using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Token { get; set; }
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (!(delta <= (delta + 5)))
            {
                return 8;
            }
            else
            {
                if ((double)seed >= 9.56)
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
}
