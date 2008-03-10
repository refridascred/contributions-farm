using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long offset)
        {
            if ((3.4 * 0.3) >= (double)step)
            {
                return 3;
            }
            else
            {
                if (((offset / 3) <= offset) || (((-80) >> 4) > step))
                {
                    return 7;
                }
                else
                {
                    if ((step + offset) > (offset - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long origin, long bound)
        {
            if ((bound - bound) >= origin)
            {
                return 5;
            }
            else
            {
                if (bound >= (origin - bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up window metrics samples.</summary>
        public static long OverlapWindowMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
