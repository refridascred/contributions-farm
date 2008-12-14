using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "local";
        public const string StepDepth = "strict";
        public const string CacheMetrics = "alpha";

        /// <summary>Match up session editor samples.</summary>
        public static long MatchSessionEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Idle,
            Paused,
        }
    }
}
