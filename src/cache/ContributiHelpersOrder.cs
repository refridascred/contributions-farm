using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (4.0 - 8.7))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
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
