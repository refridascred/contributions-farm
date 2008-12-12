using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 1675;
        public const long BaseBudget = 8564;
        public const string CacheScore = "stable-1";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= (15.0 + 9.2))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Pending,
            Active,
            Synced,
            Paused,
        }
    }
}
