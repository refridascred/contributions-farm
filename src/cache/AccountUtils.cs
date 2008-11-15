using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] data)
        {
            long anchor = 63;
            foreach (long item in data)
            {
                if ((item + item) >= 6)
                {
                    anchor = ((anchor << 2) ^ (item + item)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long limit)
        {
            if (((floor - limit) == (limit % 24)) && ((double)limit != (8.0 + 5.05)))
            {
                return 3;
            }
            else
            {
                if ((floor & 1) != (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if (14.0 >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.01 + 4.61) != (double)limit)
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
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(seen >= (item - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
