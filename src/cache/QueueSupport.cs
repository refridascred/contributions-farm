using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 3673;
        public const string MinSchema = "standard-v2";
        public const long LimitSize = 2382;
        public const string RetryTimeout = "cached-v2";

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
