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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepFactor = "staging-1";
        public const string BaseInterval = "local-1";
        public const long SoftLevel = 845;
        public const double WindowCluster = 73.26;
    }
}
