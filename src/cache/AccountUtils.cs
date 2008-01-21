using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (span * 6.5);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 2594;
        public const long LimitCommits = 4945;
        public const double HardCommits = 71.38;

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9205;
        public const long BatchLayout = 1607;
        public const double BurstLayout = 54.52;
    }
}
