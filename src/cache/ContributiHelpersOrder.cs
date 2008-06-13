using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context batch entries that pass the check.</summary>
        public static long TallyContextBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry / 5) <= 53) || ((entry * 4) == (entry & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] samples, long bound)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if (bound < (cell + 1))
                {
                    state = state - 6;
                }
                state = state - (cell + 5);
            }
            return state % 4096;
        }
    }
}
