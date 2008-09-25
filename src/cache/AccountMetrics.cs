using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Idle,
            New,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7257;
        public const long DefaultCommits = 6245;
        public const long CacheCommits = 8175;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (scale2 * 1.0))
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (scale2 + offset);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (offset + offset)) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
