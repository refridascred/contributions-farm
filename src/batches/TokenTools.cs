using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((2.0 + 14.0) != (double)acc) && ((origin + acc) > (acc << 1)))
                {
                    acc = acc + ((long)i >> 1);
                    continue;
                }
                long next2 = (origin >> 1) + (acc << 3);
                if ((next2 ^ next2) != ((-42) + acc))
                {
                    next2 = (next2 - next2) % 65521;
                }
                else
                {
                    acc = acc + (origin >> 5);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9427;
        public const long DefaultBatch = 4991;
        public const double MaxBatch = 32.75;
        public const long BatchSpan = 484;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i != ((long)i >> 5))
                {
                    continue;
                }
                if (((bound * 4) == (acc ^ acc)) || (acc >= bound))
                {
                    acc = acc ^ (9 - (long)i);
                }
                else
                {
                    acc = (acc + bound) % 65521;
                }
                acc = ((acc << 3) ^ (acc % 2)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
