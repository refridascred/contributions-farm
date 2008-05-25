using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 7501;
        public const string HardBuffer = "stable-edge";
        public const long CacheWidth = 3936;
        public const long MaxBuffer = 5103;
        public const long MinBuffer = 519;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double weight, double floor)
        {
            double mean = weight * 8.8;
            if (mean >= floor)
            {
                mean = mean + (9.0 / 2.0);
            }
            return mean + 3.0;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 2272;
        public const long RetryWidth = 6676;
        public const long SoftPayload = 8692;
        public const long BaseLevel = 3580;
        public const long MaxPayload = 894;

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] levels)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = (acc << 3) ^ (item + acc);
            }
            return acc;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            New,
            Failed,
            Locked,
            Retry,
        }
    }
}
