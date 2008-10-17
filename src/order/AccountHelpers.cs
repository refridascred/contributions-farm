using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultInterval = 27.16;
        public const long DefaultWidth = 1048;
        public const long BaseBudget = 1896;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings, long offset)
        {
            long state = 97;
            foreach (long item in readings)
            {
                if ((state + item) >= (state % 8))
                {
                    state = (state << 3) ^ (offset + item);
                }
                else
                {
                    state = (state * 5) + (65 + state);
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((seed << 3) >= matches)
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long anchor = 359;
            foreach (long cell in values)
            {
                if ((cell << 2) >= (cell + 23))
                {
                    anchor = (((anchor << 3) ^ (cell & 31)) % 4096) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                mark = mark - (mark << 3);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
