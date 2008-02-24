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

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

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
