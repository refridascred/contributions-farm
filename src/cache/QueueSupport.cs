using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every order filter entry stays within the limit.</summary>
        public static bool GuardOrderFilterRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardStream = "standard";
        public const long SoftBudget = 6307;
        public const long LimitStream = 9760;
        public const double DefaultTimeout = 25.06;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double rate = 9.52;
            return ((rate - (double)53) + gain) + bias;
        }
    }
}
