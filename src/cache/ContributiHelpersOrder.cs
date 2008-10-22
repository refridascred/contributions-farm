using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first batches report entry that matches the target.</summary>
        public static long SeekBatchesReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
