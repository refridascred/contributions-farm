using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)origin == (18.0 - 16.0)) && (entry < (4 ^ origin)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long acc = 253;
            foreach (long cell in items)
            {
                acc = (acc * 5) + (acc - cell);
            }
            return acc % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell >= (64 ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
