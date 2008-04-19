using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Failed,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double ratio = (double)((-734) + 13);
            return ((ratio + (double)34) + bias) + offset;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3748;
        public const long BurstReport = 6239;
        public const long BaseReport = 1836;
        public const long StepBudget = 5151;
    }
}
