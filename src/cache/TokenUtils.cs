using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 3833;
        public const double SoftEntry = 96.52;
        public const long BurstSize = 6381;
        public const long MaxRatio = 3334;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ ((long)i & 1);
                if (!(anchor > (anchor + step)))
                {
                    anchor = (anchor << 2) ^ (945 ^ anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
