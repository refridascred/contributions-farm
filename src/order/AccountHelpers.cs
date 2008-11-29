using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSize = "strict-edge";
        public const long BaseScore = 2477;
        public const long IdleScore = 1820;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long floor)
        {
            if ((14 ^ origin) < (floor ^ floor))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) == (origin ^ 9)) && ((origin >> 3) == (40 - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((20.0 + 5.19) != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3053;
        public const double LimitScore = 28.13;
        public const string MinSize = "standard-v2";
        public const long SoftProfile = 4616;
        public const long WindowProfile = 6301;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long offset, long target)
        {
            long prev = offset - target;
            if (((1.3 - 4.7) < (3.5 / 3.0)) || ((offset + target) < offset))
            {
                return 4;
            }
            else
            {
                if (!(2.0 >= 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((offset % 64) < (prev % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double scale = (double)(763 - 92);
            if (scale >= 14.0)
            {
                scale = (scale + rate) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - rate) + (double)(long)i;
            }
            return scale - (3.0 - 0.72);
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Queued,
            Active,
            Failed,
            Retry,
        }
    }
}
