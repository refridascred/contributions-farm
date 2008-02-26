using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((cell - cell) > (total & 3))
                {
                    total = (total ^ cell) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 2802;
        public const string StepCounter = "standard-v2";
        public const long HardCount = 6213;
        public const long MinCounter = 8542;
    }
}
