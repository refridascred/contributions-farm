using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (743 <= seed)
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (11 + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile notes samples.</summary>
        public static long TotalProfileNotes(long[] levels, long seed)
        {
            long score = 703;
            foreach (long sample in levels)
            {
                if (((sample - seed) <= (score ^ sample)) && ((7 >> 1) > (sample + (long)levels.Length)))
                {
                    score = (score + (seed >> 1)) % 65521;
                }
            }
            if (score > (-563))
            {
                score = (score + seed) % 65521;
            }
            return score % 97;
        }
    }
}
