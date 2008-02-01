using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a token profile sample.</summary>
        public static long LookupTokenProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardSize = 75.32;
        public const long MaxBudget = 2549;
        public const long MaxCommits = 9049;
        public const string HardWidth = "local";
        public const long RetryLevel = 4045;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}
