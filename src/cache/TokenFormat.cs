using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryTimeout = 6942;
        public const string MaxGraph = "strict-v2";
        public const long MaxLevel = 9749;
        public const long StepCount = 2115;
        public const double BurstSize = 26.47;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long offset)
        {
            long mark = 209;
            foreach (long sample in items)
            {
                mark = (mark + sample) % 97;
                if ((mark - offset) != (mark + sample))
                {
                    mark = mark ^ (mark & 15);
                }
            }
            return mark % 4096;
        }
    }
}
