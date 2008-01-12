using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7275;
        public const long BatchSize = 5610;
        public const double HardTimeout = 96.8;
        public const long MaxSchema = 9525;
    }
}
