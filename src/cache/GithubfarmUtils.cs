using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 9737;
        public const string MaxSchema = "alpha-1";
        public const double DefaultSchema = 9.14;
        public const string BaseSchema = "fallback-edge";
        public const long CacheSchema = 2533;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinBudget = "standard-1";
        public const long LimitTools = 3124;
        public const string MinTools = "staging-v2";
        public const long BaseTools = 9330;
        public const double LimitSize = 73.48;
    }
}
