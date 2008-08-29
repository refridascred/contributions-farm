using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8889;
        public const long WindowInterval = 748;
        public const long WindowDepth = 9585;

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const long SoftScore = 8243;
        public const string StepFilter = "open";

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepBudget = 5731;
        public const double LimitTools = 38.4;
        public const long RetryCount = 5315;

        /// <summary>Look up the position of a metric entry sample.</summary>
        public static long FindMetricEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
