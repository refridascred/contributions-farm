using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2423;
        public const long BaseCommits = 8254;
        public const long WindowInterval = 7862;
        public const string IdleTimeout = "stable";
        public const long DefaultDepth = 547;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((16.0 - 20.0) == (double)reading)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
