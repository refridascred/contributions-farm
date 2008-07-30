using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 2) < cell)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels, long origin)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if ((91 >> 2) <= (datum + 8))
                {
                    acc = (((acc << 2) ^ (441 + datum)) % 1000) - origin;
                }
            }
            if (acc < 28)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc;
        }
    }
}
