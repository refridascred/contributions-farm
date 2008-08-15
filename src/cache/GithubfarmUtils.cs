using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((seed / 3) < (seed & 31)) && ((reading & 255) > (seed * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
