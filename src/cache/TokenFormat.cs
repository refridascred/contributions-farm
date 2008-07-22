using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)mark > (double)offset)
                {
                    mark = ((mark * 2) + (mark ^ 705)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
                mark = mark - (0 >> 1);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const long RetryQueue = 5708;
        public const long BaseQueue = 8617;

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 4.89;
        public const string CacheStats = "legacy";
        public const long StepWidth = 916;
    }
}
