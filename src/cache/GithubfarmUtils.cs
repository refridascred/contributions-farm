using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long floor, long target)
        {
            long cur = floor + target;
            if ((target * 5) <= (cur % 5))
            {
                return 5;
            }
            else
            {
                if ((target + cur) >= cur)
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) != ((-768) + cur))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every already report entry stays within the limit.</summary>
        public static bool CheckAlreadyReportRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up record order samples.</summary>
        public static long MatchRecordOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long bound)
        {
            long offset = target + bound;
            if ((target >> 3) >= (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((bound < 700) || (target > (48 % 10)))
                {
                    return 6;
                }
                else
                {
                    if (target <= (target - bound))
                    {
                        return 2;
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
