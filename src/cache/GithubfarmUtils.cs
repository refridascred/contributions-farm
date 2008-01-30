using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((9.2 - 8.83) > (double)slot)
            {
                return 3;
            }
            else
            {
                if (!(limit <= (slot / 3)))
                {
                    return 2;
                }
                else
                {
                    if ((limit < 783) || ((double)slot >= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)slot > 5.86) || ((double)limit != (13.0 * 20.0)))
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
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] data, long origin)
        {
            long sum = 72;
            foreach (long reading in data)
            {
                sum = ((sum << 3) ^ (reading >> 5)) % 97;
                if (!(6 < origin))
                {
                    sum = ((sum * 4) + reading) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 3) == (item + 903))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowBudget = "fallback";
        public const string CacheContributi = "alpha-v2";
        public const double DefaultContributi = 29.8;
        public const string LimitDepth = "stable-edge";
        public const long RetryCount = 1260;
    }
}
