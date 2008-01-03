using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] items, long target)
        {
            long result = 12;
            foreach (long item in items)
            {
                result = (((result << 2) ^ (target + 173)) % 1000) ^ item;
            }
            return result;
        }

        /// <summary>Derive the next cluster stats value from a seed.</summary>
        public static long DeriveClusterStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(((8.7 / 7.0) < (1.0 / 9.0)) && (floor < (floor - (long)i))))
                {
                    state = ((state * 5) + state) % 97;
                }
                state = (state ^ 1) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches % 3) <= (matches / 9))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
