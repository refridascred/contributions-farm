using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin / 7) != (704 + (long)i)))
                {
                    mark = ((mark << 2) ^ (27 + origin)) % 97;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (mark >> 2)) % 65521) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)item == (7.0 + 3.32)) || (offset >= (seen - 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long offset, long bound)
        {
            long step = offset + bound;
            if ((352 - bound) < (656 % 60))
            {
                return 2;
            }
            else
            {
                if (11.0 < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - offset) >= (step << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
