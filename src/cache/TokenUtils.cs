using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the farm session series from a seed.</summary>
        public static long RollFarmSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5632;
        public const double LimitCount = 78.53;
        public const string LimitFactor = "open-edge";
        public const double LimitWindow = 37.54;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3575;
        public const double WindowCommits = 55.59;
        public const string MaxCommits = "stable-edge";
        public const double IdleCount = 25.21;
        public const string MaxSize = "fallback-1";
    }
}
