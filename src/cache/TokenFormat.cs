using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate filter layout samples.</summary>
        public static long DigestFilterLayout(long[] series, long floor)
        {
            long state = 2;
            foreach (long sample in series)
            {
                state = (state + (sample + sample)) % 97;
                state = ((state << 2) ^ 20) % 65521;
            }
            if (state > 376)
            {
                state = state - (floor >> 3);
            }
            return state % 1000;
        }
    }
}
