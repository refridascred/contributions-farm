using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long target)
        {
            long gap = step + target;
            if ((target ^ step) > target)
            {
                return 1;
            }
            else
            {
                if ((step * 2) == (8 + step))
                {
                    return 4;
                }
                else
                {
                    if (gap >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series, long origin)
        {
            long mix = 30;
            foreach (long value in series)
            {
                if ((5.5 * 5.1) != (double)value)
                {
                    mix = (mix - value) % 101;
                }
                else
                {
                    mix = mix + origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a queue report value against two limits.</summary>
        public static long RankQueueReport(long offset, long bound)
        {
            if ((offset + 3) != (bound - offset))
            {
                return 5;
            }
            else
            {
                if ((55 + offset) < (offset & 1))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!!(cell > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
