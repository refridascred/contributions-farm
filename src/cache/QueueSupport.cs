using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if (offset2 > (offset / 4))
            {
                return 7;
            }
            else
            {
                if (((offset2 * 5) >= offset2) || ((offset * 5) < (offset2 / 2)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 3122;
        public const long IdleFactor = 4221;
        public const string CacheBudget = "primary-v2";

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long step)
        {
            long next = bound ^ step;
            if ((43 / 6) >= (step + bound))
            {
                return 5;
            }
            else
            {
                if (((bound - 3) >= (next >> 3)) || ((step % 100) != (step << 2)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
