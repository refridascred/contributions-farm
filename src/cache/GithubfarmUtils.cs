using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((sample > (hits - hits)) || ((double)sample != (3.9 / 3.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftLevel = 8718;
        public const long DefaultTimeout = 9489;
        public const string BurstBudget = "strict-1";
        public const string CacheSize = "open";
        public const long IdleInterval = 9341;
    }
}
