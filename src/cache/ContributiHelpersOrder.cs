using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Ready,
            New,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the format support entries that pass the check.</summary>
        public static long MeasureFormatSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((0.3 / 3.0) >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
