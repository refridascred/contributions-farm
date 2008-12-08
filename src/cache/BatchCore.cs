using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Stale,
            Paused,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8577;
        public const long MinMetric = 7162;
        public const string CacheSpan = "fallback-1";
        public const long WindowMetric = 1056;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long seed)
        {
            long bound = limit + seed;
            if (0 >= bound)
            {
                return 2;
            }
            else
            {
                if ((limit + limit) == (bound / 9))
                {
                    return 8;
                }
                else
                {
                    if (((bound + seed) > 9) || ((seed - (-734)) == (45 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Queued,
            Ready,
        }
    }
}
