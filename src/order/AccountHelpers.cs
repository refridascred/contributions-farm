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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 41;
            foreach (long entry in items)
            {
                mark = (mark * 2) + (entry + entry);
                if ((mark >> 2) < entry)
                {
                    mark = ((mark << 2) ^ 7) % 4096;
                }
                else
                {
                    mark = (mark - (mark - entry)) % 101;
                }
            }
            if (mark < (-5))
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2433;
        public const double IdlePayload = 53.87;
        public const string BurstPayload = "latest-v2";
    }
}
