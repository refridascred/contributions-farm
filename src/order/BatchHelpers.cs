using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches channel input into a small class.</summary>
        public static long RankBatchesChannel(long seed, long floor)
        {
            if (((89 >> 5) >= floor) || ((seed / 4) <= (seed >> 4)))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 8.0)
                {
                    return 1;
                }
                else
                {
                    if ((seed - 753) > (floor * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed > (floor - 812))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
