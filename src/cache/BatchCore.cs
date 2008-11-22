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

        /// <summary>Rank cache commits input into a small class.</summary>
        public static long ClassifyCacheCommits(long offset, long seed)
        {
            if ((seed & 127) == (offset - offset))
            {
                return 7;
            }
            else
            {
                if (((14.0 - 9.0) == (double)offset) && ((double)seed >= (1.4 * 12.0)))
                {
                    return 0;
                }
                else
                {
                    if (((1.3 - 6.36) >= (8.5 * 4.8)) && ((offset * 5) <= (seed << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 97) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

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
