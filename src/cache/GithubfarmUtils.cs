using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "fallback-v2";
        public const long BaseBudget = 3306;
        public const long CacheLevel = 9949;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Idle,
            New,
            Synced,
            Locked,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (span - weight))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
