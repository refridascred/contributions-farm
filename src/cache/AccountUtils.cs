using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 12.69;
        public const long LimitAccount = 5546;
        public const long BurstFactor = 9734;
        public const long MinInterval = 2909;
        public const string MinAccount = "alpha-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "open-1";
        public const long IdleWidth = 9486;
        public const long LimitPayload = 1362;
        public const long BatchSpan = 5603;
        public const double BaseCount = 68.7;

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double bias2 = 5.11;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (bias2 * 1.0)) + (double)(long)i) + gain;
            }
            return bias2 + (bias - 6.83);
        }
    }
}
