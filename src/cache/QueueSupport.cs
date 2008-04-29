using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 16.83;
        public const long BatchFilter = 7041;
        public const long SoftFilter = 9442;
        public const long MaxFilter = 262;
        public const double HardFilter = 43.7;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((((long)i >> 3) <= (target >> 3)) || ((931 * 2) == (target + acc)))
                {
                    acc = ((acc << 3) ^ (target + (long)i)) % 1000;
                }
                acc = (acc - (acc << 1)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
