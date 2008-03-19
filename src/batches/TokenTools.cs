using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleTimeout = 2905;
        public const double RetryBuffer = 71.49;
        public const long MaxBuffer = 5294;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinWidth = 1961;
        public const string CacheLevel = "local-1";
        public const double BaseAlready = 5.33;
        public const long MinAlready = 4216;
    }
}
