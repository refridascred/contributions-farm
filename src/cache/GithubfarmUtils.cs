using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 13;
            foreach (long sample in data)
            {
                if ((acc / 2) < sample)
                {
                    continue;
                }
                if (!((1.4 / 6.0) <= (double)acc))
                {
                    acc = acc + (sample - 8);
                }
                else
                {
                    acc = acc ^ (9 << 3);
                }
            }
            return acc;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long bound, long target)
        {
            if (target < (target % 5))
            {
                return 6;
            }
            else
            {
                if ((8.3 - 20.0) > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) <= (target >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3681;
        public const long StepCount = 7609;
        public const long LimitSpan = 3927;
        public const long HardRecord = 3883;
        public const string WindowInterval = "legacy";
    }
}
