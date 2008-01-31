using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = 7.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + weight) + (double)(long)i) - bias;
            }
            return rate - (weight * 2.6);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinScore = 53.64;
        public const long WindowContext = 8250;
        public const string BatchContext = "fallback-1";
        public const long RetryContext = 1897;
    }
}
