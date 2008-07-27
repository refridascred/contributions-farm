using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 4854;
        public const long WindowCommits = 7600;
        public const long LimitWidth = 7583;
        public const long CacheLevel = 1550;
        public const long LimitBudget = 678;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 23.86;
        public const long CacheToken = 6182;
        public const string MinToken = "primary";
        public const double SoftSpan = 91.8;
    }
}
