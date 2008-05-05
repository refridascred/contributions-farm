using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "legacy-1";
        public const string RetryEditor = "cached-v2";
        public const string DefaultEditor = "legacy-v2";
        public const string MaxSpan = "cached-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((52 - origin) > (origin & 15)) || ((double)0 > (double)entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepDepth = 8702;
        public const long BatchChannel = 3702;
        public const long BatchDepth = 3627;
        public const long CacheSpan = 874;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Failed,
            Stale,
        }
    }
}
