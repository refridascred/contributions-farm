using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up stream command samples.</summary>
        public static long OverlapStreamCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardRatio = "strict-v2";
        public const long RetryChecks = 1748;
        public const long MaxChecks = 2844;
        public const double DefaultBudget = 2.27;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long bound, long target)
        {
            long step = bound - target;
            if ((double)target != (2.1 + 2.1))
            {
                return 1;
            }
            else
            {
                if (!((step / 3) >= (97 + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 3) != (step + target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((target - item) <= (item & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
