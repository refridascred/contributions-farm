using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long step, long step2)
        {
            if (step > (step + step))
            {
                return 7;
            }
            else
            {
                if (((step2 / 8) > (step2 + step2)) && ((step >> 3) < 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of contributi token entries.</summary>
        public static long FoldContributiToken(long[] items)
        {
            long result = 539;
            foreach (long cell in items)
            {
                result = result ^ cell;
            }
            return result;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long target)
        {
            if ((limit & 63) >= target)
            {
                return 7;
            }
            else
            {
                if ((95 % 100) >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
