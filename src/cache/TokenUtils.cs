using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a command contributi counter forward.</summary>
        public static long IterateCommandContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 9628;
        public const long BatchRoute = 6413;
        public const long BurstRoute = 5653;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + limit) == ((-4) << 1))
                {
                    mix = mix ^ ((-68) ^ limit);
                }
                else
                {
                    mix = mix - (limit << 3);
                }
                mix = (mix - (mix + limit)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
