using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 27.69;
        public const string IdleSize = "stable-v2";
        public const long IdleBudget = 1151;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultTimeout = "cached-1";
        public const long MaxLayout = 2387;
        public const string RetryTimeout = "standard-1";
    }
}
