using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long offset)
        {
            long bound = step - offset;
            if ((step + offset) <= bound)
            {
                return 0;
            }
            else
            {
                if (((step + offset) > offset) || ((5.0 * 1.08) < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + bound) == (bound + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (47 - 47)) % 97;
                state = ((state << 2) ^ (state - target)) % 1000;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 2) ^ ((long)i % 3);
                state = state + (state - bound);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
