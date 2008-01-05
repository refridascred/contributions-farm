using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route metric value from a seed.</summary>
        public static long DeriveRouteMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ (score ^ (long)i)) % 65521;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long offset)
        {
            long state = 5;
            foreach (long cell in items)
            {
                if (state >= (state + state))
                {
                    state = state ^ (3 << 3);
                }
                else
                {
                    state = ((state << 3) ^ (cell + state)) % 4096;
                }
                if ((cell + offset) >= (long)items.Length)
                {
                    state = (state << 3) ^ (cell - 69);
                }
            }
            return state;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items)
        {
            long anchor = -355;
            foreach (long item in items)
            {
                if ((double)anchor < 4.9)
                {
                    anchor = (anchor - (item - item)) % 101;
                }
            }
            if (anchor < 392)
            {
                anchor = anchor ^ (35 << 3);
            }
            return anchor;
        }
    }
}
