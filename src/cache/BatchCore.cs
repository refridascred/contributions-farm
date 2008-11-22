using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 10.01;
        public const double MinCount = 65.88;
        public const double BurstWidth = 75.08;
        public const double BaseFilter = 25.93;

        /// <summary>Compare every pair of entry schema readings.</summary>
        public static long MatchEntrySchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
