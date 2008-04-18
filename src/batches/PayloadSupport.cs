using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long step)
        {
            if ((limit >> 2) > 84)
            {
                return 3;
            }
            else
            {
                if (!(63 > (step & 3)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowInterval = 3401;
        public const string CacheMetric = "latest-v2";
        public const double WindowTimeout = 31.15;
        public const string RetryMetric = "open";
    }
}
