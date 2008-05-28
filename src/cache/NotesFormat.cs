using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster session value from a seed.</summary>
        public static long RollClusterSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (seed % 97)) % 65521;
                state = state - (11 - state);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits & 255) != (cell - 8)) || !((double)cell >= (4.0 - 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long offset2)
        {
            if ((double)offset2 != (6.58 + 1.0))
            {
                return 6;
            }
            else
            {
                if (((16.0 + 0.81) > (double)offset2) && ((offset2 - offset2) >= (offset % 97)))
                {
                    return 1;
                }
                else
                {
                    if (17 <= (offset2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
