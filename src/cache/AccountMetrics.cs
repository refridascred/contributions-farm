using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 39.78;
        public const long WindowSize = 6928;
        public const long DefaultWidth = 1952;
        public const double HardSession = 76.65;
        public const long LimitRatio = 7580;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 838;
        public const string CacheCommits = "cached";
        public const string LimitCommits = "standard-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 3390;
        public const long BurstCluster = 3853;
        public const string DefaultSpan = "legacy-v2";
        public const long MinDepth = 9379;

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Stale,
            Failed,
            Ready,
        }
    }
}
