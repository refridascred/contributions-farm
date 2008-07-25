using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            New,
            Draft,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "fallback-edge";
        public const long SoftBudget = 6963;
        public const string MaxGraph = "standard";

        /// <summary>Validate graph contributi readings against a bound.</summary>
        public static bool ValidateGraphContributiRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
