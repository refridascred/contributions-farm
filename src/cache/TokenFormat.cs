using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = ((mark * 3) + (mark - mark)) % 97;
                if ((entry + 7) < mark)
                {
                    mark = (mark - (mark ^ 187)) % 1000;
                }
                else
                {
                    mark = mark - (mark + 645);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
