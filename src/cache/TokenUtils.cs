using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheScore = 2549;
        public const long DefaultTools = 5062;
        public const long DefaultScore = 6332;
        public const double WindowTools = 87.61;

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool CheckProfileCacheLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
