using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowTimeout = 2699;
        public const long DefaultCommits = 8971;
        public const long IdleCommits = 6944;

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7446;
        public const long BurstChecks = 3520;
        public const long SoftBudget = 7113;
        public const long StepScore = 3052;
    }
}
