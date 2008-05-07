using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if (offset > (score / 4))
                {
                    score = (score * 2) + (offset + score);
                }
                score = score - (score + (long)i);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 3) ^ (37 - floor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] readings, long origin)
        {
            long state = -28;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (cell & 1))
                {
                    state = (state + cell) % 101;
                    break;
                }
                state = (state << 3) ^ (state + origin);
                if (((double)state < (11.0 * 2.9)) || ((cell + origin) <= (cell - cell)))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = state - (cell - state);
                }
            }
            return state;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LocateFormatFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
