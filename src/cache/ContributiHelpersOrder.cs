using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((origin ^ origin) > (gap * 2))
            {
                return 8;
            }
            else
            {
                if (origin >= 0)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            New,
            Closed,
            Done,
        }
    }
}
