using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a contributi counter pair into a bucket.</summary>
        public static long RankContributiCounter(long seed, long seed2)
        {
            if (((-5) / 2) != (seed2 / 2))
            {
                return 4;
            }
            else
            {
                if ((seed + seed2) >= (seed + 268))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) == (seed2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((531 * 4) < (seed2 / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long limit)
        {
            if (!((80 >> 4) >= (limit - 7)))
            {
                return 7;
            }
            else
            {
                if (((double)limit == (6.57 / 6.0)) && ((origin + origin) <= (limit & 15)))
                {
                    return 6;
                }
                else
                {
                    if (((origin * 5) > limit) || ((double)origin != (double)limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
