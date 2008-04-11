using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((seed + 202) < (item >> 3))
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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= (value >> 1))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = result - (28 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
