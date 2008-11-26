using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a commits route counter forward.</summary>
        public static long IterateCommitsRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long origin, long origin2)
        {
            long bound = origin + origin2;
            if ((863 / 2) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 9.0)
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (4 >= (bound / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank report entry input into a small class.</summary>
        public static long RankReportEntry(long origin, long floor)
        {
            long step = origin ^ floor;
            if (!(71 > (step >> 4)))
            {
                return 8;
            }
            else
            {
                if (((double)origin < (double)step) || (3 <= (9 - step)))
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
