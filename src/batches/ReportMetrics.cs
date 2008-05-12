using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2603;
        public const string MinRecord = "standard";
        public const long IdleRecord = 6158;
        public const long HardFactor = 4749;
        public const string MaxBudget = "open-v2";

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((5 * 3) < tally)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheCount = 4082;
        public const long CacheProfile = 4095;
        public const long LimitProfile = 7095;
        public const string DefaultBudget = "staging-edge";
    }
}
