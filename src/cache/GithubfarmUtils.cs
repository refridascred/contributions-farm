using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Done,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long seed)
        {
            long sum = -710;
            foreach (long cell in samples)
            {
                if (!((4.0 * 2.6) != (double)sum))
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum < 18)
            {
                sum = ((sum << 2) ^ seed) % 1000;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 8516;
        public const long IdleInterval = 1097;
        public const long StepInterval = 3803;
        public const long LimitAlready = 6690;
        public const string MinLevel = "legacy-edge";

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 387;
        public const long BaseRecord = 3089;
        public const long StepBudget = 9547;
        public const double SoftSpan = 8.04;
    }
}
