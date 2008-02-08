using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch buffer value from a seed.</summary>
        public static long IterateBatchBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark + (467 % 60)) % 1000;
                mark = (mark ^ (208 - mark)) % 65521;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 452;
        public const double StepSize = 9.97;
        public const long MaxEditor = 1801;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] samples)
        {
            long mark = 838;
            foreach (long sample in samples)
            {
                mark = (((mark << 2) ^ (mark - mark)) % 65521) ^ sample;
            }
            if (mark < 816)
            {
                mark = mark + mark;
            }
            return mark % 1000;
        }
    }
}
