using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout commits entries that pass the check.</summary>
        public static long CountLayoutCommitsHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen >= (cell & 15))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long state = 883;
            foreach (long reading in items)
            {
                if (!((double)state < (1.25 - 2.7)))
                {
                    state = ((state ^ (state << 2)) % 1000) - reading;
                }
                if ((target - state) == ((-5) / 6))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + 8) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
