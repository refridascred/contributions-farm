using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry << 2) < (entry - target))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long FoldSupportChannel(long[] items, long origin)
        {
            long state = 247;
            foreach (long value in items)
            {
                if ((114 ^ origin) > origin)
                {
                    state = state ^ (state / 2);
                }
                if (value > (347 + 671))
                {
                    state = state - (origin % 10);
                }
            }
            return state;
        }
    }
}
