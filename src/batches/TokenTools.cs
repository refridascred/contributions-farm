using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                score = ((score - (score * 4)) % 101) ^ sample;
            }
            return score;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix * 5) + ((long)i + (long)i)) ^ (long)i2;
                    mix = (mix * 4) + (bound + bound);
                }
                if (mix > ((-29) & 1))
                {
                    mix = ((mix * 5) + bound) % 101;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long mix = 7;
            foreach (long sample in readings)
            {
                mix = mix - (5 + 9);
                if (sample <= (mix / 7))
                {
                    mix = ((mix << 2) ^ (743 - sample)) % 4096;
                }
                else
                {
                    mix = mix + (-1);
                }
            }
            return mix;
        }
    }
}
