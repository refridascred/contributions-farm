using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next context route value from a seed.</summary>
        public static long StepContextRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
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
