using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstDepth = 7710;
        public const double CacheOrder = 14.28;
        public const string WindowTimeout = "staging";
        public const double BatchSpan = 18.42;
        public const long CacheDepth = 2725;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
