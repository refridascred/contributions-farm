using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + origin) != (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = 607;
            foreach (long entry in readings)
            {
                state = (((state << 3) ^ ((long)readings.Length ^ state)) % 97) ^ entry;
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Rank commits contributi input into a small class.</summary>
        public static long RankCommitsContributi(long offset, long limit)
        {
            if ((limit - limit) >= offset)
            {
                return 7;
            }
            else
            {
                if (((double)limit < (double)10) && ((limit & 15) > (limit + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 1) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
