using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 9400;
        public const string BurstWidth = "local-1";
        public const long WindowSize = 8724;
        public const string CacheTimeout = "standard-edge";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
