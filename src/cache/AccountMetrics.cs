using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((452 >= (bound - count)) && !(4 > count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally / 7) < (tally + tally)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long step)
        {
            if ((3.45 - 9.4) < (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed < (78 + step)) && (seed > (5 % 8)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
