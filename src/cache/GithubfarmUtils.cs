using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long step)
        {
            if (!((4.19 / 9.0) >= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((step % 100) > step)
                {
                    return 5;
                }
                else
                {
                    if (step <= 0)
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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ (8 - 919)) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long AuditMetricGithubfarmOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (target > (item >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report format sample.</summary>
        public static long SeekReportFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
