using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5114;
        public const double WindowBudget = 30.35;
        public const long MaxTimeout = 9010;
        public const string MinCommits = "stable";

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 56.06;
        public const long BurstSpan = 4140;
        public const long MaxSpan = 482;
    }
}
