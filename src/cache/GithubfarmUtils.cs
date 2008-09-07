using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long target)
        {
            long mark = 266;
            foreach (long reading in levels)
            {
                mark = ((mark * 3) + (6 << 1)) - target;
                mark = (mark ^ reading) % 4096;
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
