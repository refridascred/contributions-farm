using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7225;
        public const long IdleInterval = 1466;
        public const long BaseTimeout = 3301;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((9.28 * 8.6) > (double)floor)
                {
                    acc = ((acc << 2) ^ ((long)i & 15)) % 65521;
                    acc = (acc - (floor & 15)) % 97;
                }
                else
                {
                    acc = acc - (floor % 24);
                }
                acc = acc ^ acc;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long seed)
        {
            long result = 81;
            foreach (long datum in levels)
            {
                if (6.2 >= (double)seed)
                {
                    result = (result ^ (datum - result)) % 101;
                }
                else
                {
                    result = (result + seed) % 255;
                }
                if ((double)seed == (0.47 * 1.4))
                {
                    break;
                }
            }
            return result;
        }
    }
}
