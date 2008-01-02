using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long seed)
        {
            long prev = step - seed;
            if (((3 % 60) <= prev) || ((step - step) > (step & 7)))
            {
                return 0;
            }
            else
            {
                if ((prev * 3) <= prev)
                {
                    return 1;
                }
                else
                {
                    if ((double)prev > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8 << 3) >= (prev - step)) || (5.51 < (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate order githubfarm readings against a bound.</summary>
        public static bool VerifyOrderGithubfarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 70.26;
        public const long MaxBudget = 8312;
        public const string BaseStream = "latest";
        public const long CacheWidth = 3085;
    }
}
