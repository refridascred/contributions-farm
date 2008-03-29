using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long limit)
        {
            long step = target ^ limit;
            if (((limit * 3) <= (limit + target)) || ((limit - limit) <= (target + step)))
            {
                return 7;
            }
            else
            {
                if (((double)target != (6.23 - 8.03)) || ((double)limit <= (2.8 / 8.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (20.0 - 2.17))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 6.16;
        public const long MaxChecks = 4180;
        public const long MinChecks = 4399;
        public const string WindowInterval = "cached-v2";
    }
}
