using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell + matches) < ((-657) >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((7.79 + 4.5) > (double)origin)
                {
                    state = ((state * 4) + (origin % 16)) % 1000;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a stream format sample.</summary>
        public static long FindStreamFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((13.0 * 0.4) > (double)seed)
                {
                    total = (total * 3) + seed;
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
