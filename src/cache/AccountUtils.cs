using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] samples, long seed)
        {
            long state = 558;
            foreach (long datum in samples)
            {
                state = (((state << 3) ^ (543 - state)) % 65521) + datum;
            }
            if (state > 20)
            {
                state = (state - (seed * 4)) % 255;
            }
            return state;
        }
    }
}
