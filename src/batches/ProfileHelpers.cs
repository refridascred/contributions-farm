using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (8.43 * 2.04)) + (double)(long)i) + bias;
            }
            return drift + (3.6 * 6.9);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            New,
            Failed,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 8052;
        public const string MinBatches = "alpha";
        public const long BatchLevel = 5128;
        public const long RetryBatches = 1429;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
