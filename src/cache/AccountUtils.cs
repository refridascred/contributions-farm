using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-edge";
        public const double HardBudget = 74.12;
        public const long CacheCount = 8706;
        public const long RetryFarm = 6226;
    }
}
