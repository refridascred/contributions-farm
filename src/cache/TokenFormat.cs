using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer token value against two limits.</summary>
        public static long GradeBufferToken(long origin, long offset)
        {
            if (!(origin > (origin / 2)))
            {
                return 3;
            }
            else
            {
                if (((3.2 / 9.0) > (double)origin) || ((4 ^ origin) > 3))
                {
                    return 1;
                }
                else
                {
                    if ((origin / 4) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
