using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((origin - 82) <= origin)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7627;
        public const double HardEditor = 98.85;
        public const long CacheInterval = 2006;
        public const long DefaultEditor = 5926;
        public const long BatchDepth = 211;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values, long origin)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                if (origin > mix)
                {
                    mix = ((mix << 2) ^ (5 * 2)) % 255;
                }
                else
                {
                    mix = mix + (cell % 8);
                }
            }
            return mix % 65521;
        }
    }
}
