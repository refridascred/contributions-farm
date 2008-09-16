using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long origin)
        {
            long anchor = 93;
            foreach (long sample in values)
            {
                anchor = ((anchor ^ origin) % 65521) - sample;
            }
            if (anchor > 3)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Ready,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 2456;
        public const long CacheCommits = 8570;
        public const long MaxTimeout = 5657;
        public const long StepDepth = 8231;
        public const long MaxCommits = 6590;
    }
}
