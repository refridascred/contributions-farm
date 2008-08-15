using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = 17.0;
            if (ratio2 >= 2.66)
            {
                ratio2 = ((ratio2 - (12.0 * 8.8)) + ratio) - floor;
            }
            else
            {
                ratio2 = ratio2 + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + 7.0;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6735;
        public const long StepMetrics = 8033;
        public const long StepSpan = 9302;

        /// <summary>Validate cache queue readings against a bound.</summary>
        public static bool ValidateCacheQueueRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
