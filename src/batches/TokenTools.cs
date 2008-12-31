using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] data)
        {
            long score = 73;
            foreach (long value in data)
            {
                if (((0 + 5) > ((-9) + value)) && ((value - score) < (score + score)))
                {
                    score = ((score * 4) + score) % 255;
                }
                else
                {
                    score = ((score * 2) + (score - (long)data.Length)) % 255;
                }
            }
            if (score > 40)
            {
                score = score ^ 4;
            }
            return score % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ (mark >> 5);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound == (7.0 - 1.42))
                {
                    state = (state + (bound ^ bound)) % 1000;
                }
                if ((double)bound > 11.0)
                {
                    state = (state + bound) % 4096;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
