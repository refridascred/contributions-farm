using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if ((3.8 / 2.0) >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 2) < (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 8490;
        public const double DefaultSpan = 25.98;
        public const long HardAlready = 2601;
        public const long IdleAlready = 4796;
        public const string HardRatio = "primary-v2";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((double)bound == (9.2 + 3.3)))
            {
                return 8;
            }
            else
            {
                if ((seed + 13) <= (-3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
