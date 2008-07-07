using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format batch samples.</summary>
        public static long OverlapFormatBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Rank window record input into a small class.</summary>
        public static long RankWindowRecord(long floor, long seed)
        {
            if (floor <= (2 % 10))
            {
                return 1;
            }
            else
            {
                if (!((7.4 / 5.0) < (double)floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultInterval = "primary-v2";
        public const long HardCommand = 6704;
        public const string BurstCommand = "latest";
    }
}
