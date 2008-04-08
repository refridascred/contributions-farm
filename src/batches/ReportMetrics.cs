using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long offset)
        {
            if (!((seed - offset) < (seed / 6)))
            {
                return 5;
            }
            else
            {
                if ((19.0 + 7.02) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed - offset) < (offset - 41)) && ((seed % 97) >= (offset / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context stats value against two limits.</summary>
        public static long RankContextStats(long bound, long origin)
        {
            if ((double)bound >= (17.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((origin - bound) < origin)
                {
                    return 1;
                }
                else
                {
                    if (origin >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound <= (2.8 - 6.6))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
