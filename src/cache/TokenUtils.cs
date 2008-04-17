using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5250;
        public const string SoftLevel = "local-1";
        public const double LimitEntry = 64.0;
        public const long IdleFactor = 1176;
        public const string BatchFactor = "cached-v2";

        /// <summary>Look up the position of a route layout sample.</summary>
        public static long FindRouteLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
