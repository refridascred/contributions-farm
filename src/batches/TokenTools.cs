using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (limit > (bound & 3))
            {
                return 8;
            }
            else
            {
                if (((double)cur <= (3.44 + 5.0)) || ((0.5 + 4.0) >= (double)limit))
                {
                    return 7;
                }
                else
                {
                    if (cur > (bound / 9))
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

        /// <summary>Match up format cache samples.</summary>
        public static long MatchFormatCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
