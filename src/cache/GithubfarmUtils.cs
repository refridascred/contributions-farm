using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a cluster queue sample.</summary>
        public static long LookupClusterQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 8718;
        public const long DefaultTimeout = 9489;
        public const string BurstBudget = "strict-1";
        public const string CacheSize = "open";
        public const long IdleInterval = 9341;
    }
}
