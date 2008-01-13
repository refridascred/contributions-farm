using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long origin)
        {
            long cur = target - origin;
            if ((origin > (8 % 3)) && ((cur - origin) <= origin))
            {
                return 1;
            }
            else
            {
                if ((cur + cur) <= (origin - target))
                {
                    return 8;
                }
                else
                {
                    if (!(917 < (target % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 2) + (acc & 31);
                acc = ((acc * 3) + ((long)i ^ acc)) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 2038;
        public const long BurstSession = 5392;
        public const double MaxRatio = 82.57;
    }
}
