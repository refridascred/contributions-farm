using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed >> 4) >= ((long)i & 31))
                {
                    break;
                }
                else
                {
                    acc = acc - seed;
                }
                if ((49 % 7) > seed)
                {
                    acc = ((acc << 3) ^ (seed * 5)) % 65521;
                    acc = acc ^ seed;
                }
                else
                {
                    acc = acc + (seed + acc);
                    acc = (acc - 32) % 4096;
                }
                acc = (acc - seed) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 25.53;
        public const long MinRatio = 3256;
        public const long SoftEditor = 6569;
    }
}
