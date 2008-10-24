using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9304;
        public const string RetryContext = "alpha-1";
        public const string HardContext = "local-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3442;
        public const long BurstRatio = 9345;
        public const double BatchAccount = 48.83;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepScore = 2919;
        public const long SoftBudget = 6972;
        public const long RetryMetrics = 6939;
        public const double RetryBudget = 31.25;

        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool ValidateNotesAlreadyBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
