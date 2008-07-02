using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((datum ^ count) == (count >> 3)) && ((seed + seed) >= (66 << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 143;
            foreach (long datum in values)
            {
                if ((long)values.Length > (anchor + anchor))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = (anchor - (datum / 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long seed)
        {
            if (9.0 < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((-9) < seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (limit & 7)) || ((limit + limit) <= (seed & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed != (3.8 - 0.4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
