using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up farm checks samples.</summary>
        public static long MatchFarmChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
