using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7272;
        public const string BatchStats = "legacy-1";
        public const long RetrySpan = 4903;
        public const long DefaultBudget = 1528;
        public const string MaxStats = "stable";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double mean = (double)307 * 9.7;
            if (mean >= (8.6 - floor))
            {
                mean = (mean + (mean / 4.0)) - bias;
            }
            return mean + 4.76;
        }
    }
}
