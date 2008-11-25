using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Rank tools notes input into a small class.</summary>
        public static long ClassifyToolsNotes(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((double)cur <= 5.72)
            {
                return 8;
            }
            else
            {
                if (cur >= limit)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long state = 8;
            foreach (long sample in levels)
            {
                if (((335 ^ state) == (sample + state)) || ((double)sample <= (double)state))
                {
                    state = (state + (state ^ 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)sample == (1.17 + 5.5)) || !((sample + sample) <= (offset % 7)))
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
    }
}
