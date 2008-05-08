using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "open-v2";
        public const long RetryContext = 9687;
        public const long RetryBudget = 2588;
        public const long WindowLevel = 8103;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardTimeout = 1552;
        public const long SoftContributi = 2708;
        public const long CacheContributi = 4511;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 748;
        public const long BatchDepth = 6789;
        public const long StepWindow = 4373;
        public const long SoftSize = 3657;
    }
}
