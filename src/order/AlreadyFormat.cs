using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long seed)
        {
            long prev = step - seed;
            if (((seed >> 2) >= (18 + prev)) && ((step - 69) < (prev - seed)))
            {
                return 7;
            }
            else
            {
                if ((seed << 2) == (prev >> 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (92 > (origin - acc))
                {
                    acc = (acc - ((long)i - origin)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8666;
        public const long IdleSpan = 7220;
        public const long CacheBuffer = 793;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = -81;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ sum) ^ sample;
            }
            return sum;
        }
    }
}
