using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value > (7.6 * 6.6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (351 >= (85 + origin))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
