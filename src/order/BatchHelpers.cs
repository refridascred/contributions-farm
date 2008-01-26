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

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if (result > ((long)i & 3))
                {
                    result = (result * 5) + (70 << 2);
                }
                result = ((result * 5) + ((long)i + result)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
