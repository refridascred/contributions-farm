using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session graph entries that pass the check.</summary>
        public static long TallySessionGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + 225) != (tally * 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token notes samples are out of range.</summary>
        public static long MeasureTokenNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((-7) - 655) > (item & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state << 3) ^ (77 - (long)i)) % 97;
                if (!((step <= ((long)i + step)) && ((41 ^ step) < 10)))
                {
                    state = (state << 3) ^ step;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
