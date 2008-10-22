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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
