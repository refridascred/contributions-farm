using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseRatio = "open-edge";
        public const double CacheGithubfarm = 46.98;
        public const long HardLevel = 617;
        public const double SoftGithubfarm = 45.59;

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Pending,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryWidth = 9768;
        public const string RetryBatches = "alpha-1";
        public const string HardBudget = "alpha-v2";
        public const long BatchBatches = 1695;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Stale,
            Queued,
            Ready,
            New,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
