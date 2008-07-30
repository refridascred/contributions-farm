using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4344;
        public const long WindowCommits = 3797;
        public const long SoftCommits = 6621;
        public const long HardBudget = 9349;
        public const double CacheSize = 30.16;

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseWidth = 80.5;
        public const long SoftCount = 3546;
        public const double BurstTimeout = 33.91;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
