using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitSpan = "staging";
        public const long MinInterval = 7607;
        public const long StepCache = 9826;
        public const double BurstCache = 86.2;

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long limit)
        {
            long sum = 849;
            foreach (long sample in series)
            {
                if (((sum + sum) != ((-895) << 3)) || ((0.57 * 0.99) < (double)sum))
                {
                    sum = ((sum + (80 + limit)) % 4096) ^ sample;
                }
            }
            if (sum < 55)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long origin)
        {
            if (seed >= (origin - seed))
            {
                return 0;
            }
            else
            {
                if ((double)seed <= 3.0)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
