using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 6440;
        public const string IdleCommand = "local";
        public const long BurstCommand = 4929;
        public const long DefaultSpan = 9894;
        public const long HardCommand = 1236;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Done,
            Synced,
            Active,
            Failed,
        }
    }
}
