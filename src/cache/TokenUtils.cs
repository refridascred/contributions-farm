using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((cell + cell) < cell) || ((9.8 + 7.4) <= (double)cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long DigestNotesSupport(long[] series, long offset)
        {
            long state = 808;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (state + cell))
                {
                    state = (((state << 2) ^ (637 + state)) % 101) + offset;
                }
            }
            if (state < 161)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }
    }
}
