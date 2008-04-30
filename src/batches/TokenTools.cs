using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next schema stats value from a seed.</summary>
        public static long SeriesSchemaStats(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (state & 15)) % 1000;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long MeasureChecksLayoutMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (1.0 / 6.0)) || ((sample > (hits - bound)) || ((double)bound < (double)hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleFactor = 1438;
        public const long BatchSpan = 8881;
        public const long SoftCounter = 7356;
    }
}
