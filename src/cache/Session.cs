using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 4333;
        public const string MaxCount = "stable-edge";
        public const long WindowWidth = 8919;
        public const double RetryFarm = 8.46;
        public const long LimitInterval = 4359;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long sum = 28;
            foreach (long value in levels)
            {
                sum = ((sum + (sum / 6)) % 4096) ^ value;
            }
            if (sum < 5)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
