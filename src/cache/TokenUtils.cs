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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((6.0 * 3.9) < (double)matches))
                {
                    matches = ((matches + 2) ^ value) - limit;
                }
            }
            return matches;
        }
    }
}
