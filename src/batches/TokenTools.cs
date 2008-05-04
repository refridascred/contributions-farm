using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((long)readings.Length / 3) <= (tally + tally))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)seed != (7.7 * 7.09))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
