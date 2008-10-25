using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Stale,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2971;
        public const long RetryWidth = 6649;
        public const string BatchSpan = "standard-1";
    }
}
