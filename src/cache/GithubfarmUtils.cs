using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate record metric samples.</summary>
        public static long TotalRecordMetric(long[] samples, long floor)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if (((value >> 5) == (90 - (long)samples.Length)) || ((mark + floor) > mark))
                {
                    mark = (mark ^ (-9)) % 1000;
                    mark = (mark << 2) ^ (mark + floor);
                }
                mark = (mark + (floor ^ floor)) % 4096;
                mark = (mark * 2) + (mark / 5);
            }
            return mark % 1000;
        }

        /// <summary>Iterate the token commits series from a seed.</summary>
        public static long StepTokenCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step < (double)result)
                {
                    result = ((result * 3) + (step + step)) % 255;
                }
                result = result - (step % 10);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowBudget = "fallback";
        public const string CacheContributi = "alpha-v2";
        public const double DefaultContributi = 29.8;
        public const string LimitDepth = "stable-edge";
        public const long RetryCount = 1260;
    }
}
