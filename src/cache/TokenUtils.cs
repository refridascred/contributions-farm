using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 5958;
        public const string BurstCount = "alpha-v2";
        public const string IdleSize = "cached-v2";

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            New,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
