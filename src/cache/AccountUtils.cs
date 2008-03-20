using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double drift = 3.0;
            if (drift <= 2.7)
            {
                drift = drift - (floor * 8.8);
            }
            else
            {
                drift = drift + (ratio * 4.0);
            }
            return drift + drift;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const long RetryLevel = 9023;
        public const long IdleBudget = 4516;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
