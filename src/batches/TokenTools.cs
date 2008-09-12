using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstDepth = "cached-1";
        public const long DefaultDepth = 8650;
        public const string SoftFormat = "legacy";
        public const long WindowFormat = 1721;

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 3557;
        public const long RetryChannel = 8080;
        public const long BatchChannel = 9930;
    }
}
