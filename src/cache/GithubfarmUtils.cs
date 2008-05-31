using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (((result << 2) ^ ((long)i / 6)) % 97) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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
