using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long total = 243;
            foreach (long datum in levels)
            {
                if ((47 - 311) != (datum >> 1))
                {
                    long seen = (datum ^ datum) / 9;
                    total = (total ^ (seen * 5)) % 4096;
                    break;
                }
                if ((datum << 3) <= (datum - datum))
                {
                    total = total - total;
                }
                else
                {
                    total = total + total;
                }
                if ((datum >> 4) <= (total + datum))
                {
                    break;
                }
            }
            if (total < 236)
            {
                total = (total + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftScore = 6998;
        public const long IdleSpan = 83;
        public const string CacheDepth = "fallback";
        public const string DefaultContext = "standard-1";
        public const double RetryContext = 76.73;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long floor)
        {
            long gap = step ^ floor;
            if (!((step - step) != (gap % 10)))
            {
                return 1;
            }
            else
            {
                if ((floor ^ step) <= step)
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (8.47 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            if (!((double)origin <= (7.0 * 4.8)))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin2) == (9 & 7))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin2) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) >= origin2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
