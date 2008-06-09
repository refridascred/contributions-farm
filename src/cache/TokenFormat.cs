using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine graph session values into a single score.</summary>
        public static long TallyGraphSession(long[] levels, long seed)
        {
            long state = 173;
            foreach (long item in levels)
            {
                state = (state + (state << 3)) ^ item;
                if (seed <= state)
                {
                    state = ((state << 3) ^ (seed % 8)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.25 / 4.0) != (double)datum)
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long origin)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total + (origin << 3)) + value;
                total = (total + total) % 1000;
            }
            return total;
        }
    }
}
