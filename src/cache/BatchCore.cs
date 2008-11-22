using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a layout tools pair into a bucket.</summary>
        public static long SortLayoutTools(long step, long offset)
        {
            if (((1.38 / 5.0) > (double)offset) && ((step + 99) >= (offset - offset)))
            {
                return 6;
            }
            else
            {
                if ((double)step == (4.0 / 3.0))
                {
                    return 1;
                }
                else
                {
                    if ((398 + step) < (offset * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step < 6.4) || ((double)offset != (8.8 + 0.5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
