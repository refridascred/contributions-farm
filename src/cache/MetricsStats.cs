using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] values)
        {
            long sum = 491;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ (item / 3)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-1";
        public const string BurstGithubfarm = "alpha-edge";
        public const string DefaultGithubfarm = "fallback-edge";
        public const string SoftWidth = "standard";

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double bias2 = (double)(794 * 5);
            if (bias2 < (double)(-3))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
