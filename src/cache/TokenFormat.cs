using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ (carry << 2)) % 1000;
                carry = ((carry * 5) + ((long)i * 2)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long AuditFilterStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value - value) >= (value % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
