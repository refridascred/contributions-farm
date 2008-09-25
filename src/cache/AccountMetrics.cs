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

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 6126;
        public const long MinFormat = 3471;
        public const string CacheFormat = "legacy-edge";

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ score) ^ (long)i2;
                    score = (score + score) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
