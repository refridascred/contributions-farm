using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 6630;
        public const string LimitAccount = "stable-v2";
        public const double WindowLevel = 87.69;
        public const long BatchAccount = 6057;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = (weight + weight) + rate;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 2.47) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 2470;
        public const long BurstScore = 6784;
        public const long BurstBatches = 2538;
        public const long WindowBatches = 7096;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry % 24);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double weight = bias2;
            if (weight >= (weight - bias))
            {
                weight = weight - (bias2 - weight);
            }
            else
            {
                weight = weight + (weight / 7.0);
            }
            return weight - (double)7;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Locked,
            Synced,
            Draft,
            Active,
        }
    }
}
