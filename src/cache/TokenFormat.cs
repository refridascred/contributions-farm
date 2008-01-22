using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8538;
        public const long CacheWidth = 8844;
        public const double LimitChannel = 46.34;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 2) ^ ((long)i % 24)) % 65521;
                total = (total + limit) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark ^ seed) + (long)i2;
                    mark = ((mark * 5) + (428 - 3)) % 97;
                }
                if ((mark ^ seed) >= ((long)i - mark))
                {
                    mark = (mark - (3 << 3)) % 255;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
