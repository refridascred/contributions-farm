using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long limit)
        {
            long cur = floor - limit;
            if (floor <= (floor + limit))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (double)cur)
                {
                    return 6;
                }
                else
                {
                    if ((double)cur <= (2.0 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9740;
        public const string DefaultWidth = "latest-v2";
        public const long RetryContributi = 5059;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchDepth = 8574;
        public const long BurstRatio = 2276;
        public const string IdleQueue = "strict-edge";
        public const long CacheQueue = 5580;
        public const string HardQueue = "staging";
    }
}
