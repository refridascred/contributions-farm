using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)seed > (double)acc)
                {
                    acc = ((acc << 3) ^ (seed & 3)) % 97;
                }
                acc = (acc - (long)i) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long seed)
        {
            long score = 3;
            foreach (long cell in readings)
            {
                if ((score << 1) == ((-60) * 4))
                {
                    score = ((score << 2) ^ (38 ^ cell)) % 65521;
                    score = ((score << 3) ^ score) % 97;
                }
                if (425 < (seed ^ cell))
                {
                    score = score ^ (-4);
                }
                if (((seed << 1) <= (score - cell)) && ((1.15 - 8.0) <= (double)score))
                {
                    score = (score ^ (cell + seed)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 33.51;
        public const long DefaultCounter = 9399;
        public const long SoftCounter = 2031;
    }
}
