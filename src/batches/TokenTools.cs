using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (4.9 * 4.5))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= (6.6 + 5.0))
                {
                    hits = ((hits + 1) ^ reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((4 + 641) < acc)
                {
                    acc = (acc - 102) % 65521;
                }
                else
                {
                    acc = (acc ^ 379) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
