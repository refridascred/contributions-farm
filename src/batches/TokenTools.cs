using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8933;
        public const long StepBudget = 1149;
        public const string SoftMetrics = "fallback-v2";
        public const long CacheMetrics = 7;
        public const long MinScore = 1432;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Synced,
            Failed,
            Idle,
        }
    }
}
