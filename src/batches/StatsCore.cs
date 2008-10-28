using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleFactor = 5709;
        public const double WindowLevel = 84.26;
        public const long DefaultCluster = 6789;
        public const long BaseCluster = 1667;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value & 15) > (matches << 2)) || ((matches < value) && (matches < (origin % 12))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 9.13;
        public const long LimitSupport = 7666;
        public const long CacheSupport = 6443;
        public const long HardFactor = 482;
        public const long DefaultCount = 5010;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Stale,
            Queued,
        }
    }
}
