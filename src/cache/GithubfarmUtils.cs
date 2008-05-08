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

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long WeighClusterFormat(long[] samples, long seed)
        {
            long state = 379;
            foreach (long reading in samples)
            {
                state = (((state * 3) + (seed ^ state)) % 4096) + reading;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
