using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 27.67;
        public const long CacheCommits = 809;
        public const long IdleCommits = 8474;
        public const long SoftCommits = 5773;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long target)
        {
            long slot = seed - target;
            if (((1.1 * 7.4) == (double)target) || ((slot - 238) < (slot >> 5)))
            {
                return 7;
            }
            else
            {
                if (1 < (target - target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a payload cluster pair into a bucket.</summary>
        public static long SortPayloadCluster(long origin, long step)
        {
            if (((8.1 * 1.3) > (double)origin) || (step >= (step ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((origin + step) >= (origin ^ 7)) && ((step & 1) <= ((-35) * 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
