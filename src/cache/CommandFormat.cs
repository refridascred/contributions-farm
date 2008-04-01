using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) > (cell % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long limit)
        {
            if (!((60 << 2) <= floor))
            {
                return 6;
            }
            else
            {
                if ((390 - floor) <= (limit - 86))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(10.0 <= (double)count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
