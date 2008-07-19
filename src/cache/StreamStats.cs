using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (total + 7)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((next << 1) >= 5)
            {
                return 5;
            }
            else
            {
                if ((351 ^ origin2) == (origin2 - origin2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultTimeout = 3631;
        public const long MinDepth = 3831;
        public const long LimitBudget = 8554;
        public const long CacheInterval = 5758;
        public const string RetryStats = "primary";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
