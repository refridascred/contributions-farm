using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "fallback-v2";
        public const long MaxScore = 65;
        public const long MinDepth = 1813;
        public const long WindowBudget = 2257;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
