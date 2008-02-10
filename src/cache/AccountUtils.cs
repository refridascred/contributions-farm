using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double rate = (double)(92 - 426);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - gain;
            }
            return rate + offset;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Stale,
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 62.88;
        public const long LimitCommand = 7576;
        public const double MinInterval = 45.01;
    }
}
