using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheCount = 2185;
        public const long BatchPayload = 7262;
        public const double MaxInterval = 77.94;
        public const long WindowPayload = 2554;

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
