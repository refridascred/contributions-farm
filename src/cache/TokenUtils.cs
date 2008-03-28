using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)origin > (9.4 + 1.2)))
                {
                    state = (state - (state / 2)) % 4096;
                }
                state = state + origin;
                state = (state + ((long)i * 5)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 1216;
        public const double RetryTimeout = 84.83;
        public const long BurstTimeout = 476;
        public const long MaxDepth = 7411;
    }
}
