using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long state = 3;
            foreach (long entry in series)
            {
                if (entry >= (entry - 7))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                else
                {
                    state = state ^ (state ^ state);
                }
            }
            if (state > 89)
            {
                state = ((state * 4) + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Derive the next commits window value from a seed.</summary>
        public static long SeriesCommitsWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + 5) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
