using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long bound, long target)
        {
            if (((9.0 - 0.53) < (double)target) && ((bound * 2) != (bound & 255)))
            {
                return 1;
            }
            else
            {
                if (!((target - bound) < bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many notes counter samples are out of range.</summary>
        public static long CountNotesCounterMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((hits > (hits << 1)) || ((sample & 63) > 545)) && ((0.05 * 20.0) == (double)bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
