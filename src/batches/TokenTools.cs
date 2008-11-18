using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9304;
        public const long BurstRecord = 1221;
        public const double CacheScore = 50.09;
        public const string CacheRecord = "latest";
        public const long DefaultSize = 5917;

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long limit)
        {
            if (origin <= (origin / 2))
            {
                return 8;
            }
            else
            {
                if (18.0 <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Draft,
            Failed,
            Closed,
        }
    }
}
