using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long seed)
        {
            if (((limit << 3) > (938 - seed)) && ((double)seed != (2.08 * 9.99)))
            {
                return 4;
            }
            else
            {
                if (((limit ^ seed) < (269 >> 4)) && ((double)limit >= 6.24))
                {
                    return 7;
                }
                else
                {
                    if ((752 * 3) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            New,
            Paused,
            Stale,
            Retry,
        }
    }
}
