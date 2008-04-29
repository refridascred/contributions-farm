using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long target)
        {
            long cur = bound ^ target;
            if (6.0 <= (double)cur)
            {
                return 7;
            }
            else
            {
                if ((double)bound > (0.6 + 3.0))
                {
                    return 4;
                }
                else
                {
                    if (cur >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSize = 4257;
        public const long IdleBudget = 1799;
        public const long HardCache = 1545;
        public const long CacheDepth = 658;

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
