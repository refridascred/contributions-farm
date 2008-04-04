using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Active,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches + matches) >= (9 ^ reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = state + (965 >> 3);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
