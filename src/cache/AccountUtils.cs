using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Closed,
            Pending,
            New,
            Ready,
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)(197 * 5);
            return ((bias3 - bias3) + bias) + bias2;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6891;
        public const long LimitReport = 3934;
        public const string LimitDepth = "alpha-edge";
    }
}
