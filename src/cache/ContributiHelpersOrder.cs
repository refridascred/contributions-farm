using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long origin)
        {
            long anchor = 22;
            foreach (long value in items)
            {
                anchor = (anchor + (value << 2)) - origin;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next batches checks value from a seed.</summary>
        public static long SeriesBatchesChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state + offset) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
