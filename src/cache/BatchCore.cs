using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count report already pairs that satisfy a relation.</summary>
        public static long PairReportAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long carry = 857;
            foreach (long entry in series)
            {
                if (((0.3 - 5.32) >= (double)step) || (entry < (carry - entry)))
                {
                    carry = (carry + (carry + 7)) % 4096;
                }
                else
                {
                    carry = carry + (3 / 8);
                }
            }
            return carry;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long span = bound + limit;
            if ((bound + 2) != (limit & 127))
            {
                return 1;
            }
            else
            {
                if (!(7.9 <= (double)span))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a commits format reading by value.</summary>
        public static long LocateCommitsFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
