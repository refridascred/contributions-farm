using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long bound, long limit)
        {
            if ((double)bound >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) == (bound << 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 2966;
        public const double WindowLevel = 52.09;
        public const double CacheContributi = 66.35;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxScore = "open-1";
        public const string BurstFactor = "legacy-v2";
        public const long MaxQueue = 7139;
        public const double LimitQueue = 64.3;
    }
}
