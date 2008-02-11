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

        /// <summary>Rank checks command input into a small class.</summary>
        public static long RankChecksCommand(long floor, long offset)
        {
            if (((offset % 60) != (offset % 7)) && (75 > (floor % 60)))
            {
                return 1;
            }
            else
            {
                if (((double)offset > 5.6) && ((offset - floor) < (floor % 64)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
