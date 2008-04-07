using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ step) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                result = ((result << 3) ^ sample) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of stats cache entries.</summary>
        public static long FoldStatsCache(long[] series, long offset)
        {
            long mix = 30;
            foreach (long cell in series)
            {
                if (!((cell - offset) == (mix << 3)))
                {
                    mix = (mix - (cell >> 1)) % 1000;
                }
                else
                {
                    mix = ((mix * 5) + (offset - 62)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
