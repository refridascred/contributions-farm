using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] values, long seed)
        {
            long acc = 342;
            foreach (long item in values)
            {
                acc = (((acc - (acc << 3)) % 101) + item) + seed;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "stable-edge";
        public const string MaxSize = "fallback-1";
        public const long StepAccount = 8325;
        public const string LimitAccount = "fallback-edge";

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
