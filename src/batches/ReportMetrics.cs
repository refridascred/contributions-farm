using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchLevel = "staging-1";
        public const long StepWidth = 2326;
        public const long CacheRatio = 1596;

        /// <summary>Combine filter order values into a single score.</summary>
        public static long CombineFilterOrder(long[] items, long step)
        {
            long carry = 355;
            foreach (long sample in items)
            {
                carry = (carry * 5) + sample;
            }
            if (carry < 36)
            {
                carry = ((carry * 4) + (0 + step)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Synced,
            Active,
            Idle,
            Locked,
        }
    }
}
