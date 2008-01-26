using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up counter account samples.</summary>
        public static long MatchCounterAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank stats profile input into a small class.</summary>
        public static long SortStatsProfile(long target, long limit)
        {
            long diff = target ^ limit;
            if ((target & 3) != (9 + limit))
            {
                return 3;
            }
            else
            {
                if ((diff & 1) >= (limit + diff))
                {
                    return 8;
                }
                else
                {
                    if (((6.1 + 5.3) < (double)diff) && (limit <= (diff & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
