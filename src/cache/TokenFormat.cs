using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values, long origin)
        {
            long total = 6;
            foreach (long datum in values)
            {
                if (!(9 >= origin))
                {
                    total = (total + (45 + datum)) % 97;
                }
            }
            if (total < (-58))
            {
                total = ((total << 2) ^ (total / 6)) % 101;
            }
            return total;
        }

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
