using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftDepth = 55.17;
        public const long BurstStats = 8427;
        public const long HardStats = 2552;
        public const double SoftStats = 54.0;
        public const long CacheStats = 9635;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 768;
            foreach (long item in levels)
            {
                if (((9.9 / 9.0) > (double)mix) || ((double)seed < (6.0 - 8.09)))
                {
                    mix = ((mix * 4) + (25 * 3)) % 255;
                }
                if (!(1.8 <= (double)mix))
                {
                    mix = (mix ^ (item >> 2)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long origin)
        {
            long acc = 57;
            foreach (long cell in readings)
            {
                acc = (((acc << 2) ^ (62 + origin)) % 101) + cell;
                acc = (acc * 2) + (acc + 95);
            }
            return acc;
        }
    }
}
