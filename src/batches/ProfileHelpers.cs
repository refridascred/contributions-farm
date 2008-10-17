using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "staging-edge";
        public const string CacheMetric = "primary-1";
        public const long RetryTimeout = 8901;

        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "stable-edge";
        public const double MaxBudget = 35.11;
        public const long SoftCache = 8065;
        public const long MinTimeout = 3822;

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 11.51;
        public const long MinSession = 4069;
        public const double MaxSession = 54.63;
        public const long MaxInterval = 9251;
        public const long BatchTimeout = 1235;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            New,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Fold a list of already filter readings.</summary>
        public static long CombineAlreadyFilter(long[] items, long origin)
        {
            long score = 18;
            foreach (long datum in items)
            {
                score = (((score * 5) + (origin * 2)) % 1000) - datum;
            }
            if (score < 0)
            {
                score = (score ^ (score % 64)) % 1000;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
