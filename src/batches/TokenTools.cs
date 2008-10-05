using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 82.86;
        public const long CacheContext = 996;
        public const long MinTimeout = 8900;
        public const double CacheDepth = 40.42;
        public const long MaxWidth = 9421;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 899;
            foreach (long item in items)
            {
                result = ((result << 3) ^ (result * 2)) ^ item;
            }
            return result;
        }
    }
}
