using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples, long floor)
        {
            long sum = 22;
            foreach (long datum in samples)
            {
                if ((sum - sum) >= (datum % 100))
                {
                    sum = (((sum * 3) + (datum & 1)) % 4096) + floor;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((9.5 - 5.93) == (double)bound) && (((long)i << 1) > bound))
                {
                    total = total - (bound ^ total);
                    total = total + bound;
                }
                else
                {
                    total = ((total * 3) + (bound & 1)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
