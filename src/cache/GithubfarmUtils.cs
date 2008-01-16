using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultWidth = 12.79;
        public const long MinRatio = 9513;
        public const long CacheSchema = 671;
        public const long SoftSchema = 3404;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long bound)
        {
            long span = origin - bound;
            if ((74 & 63) > (span * 4))
            {
                return 8;
            }
            else
            {
                if (origin <= (span + bound))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many cache contributi samples are out of range.</summary>
        public static long AuditCacheContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (0 - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if ((6.0 + 15.0) != (double)sum)
                {
                    sum = ((sum * 3) + reading) % 1000;
                }
                else
                {
                    sum = (sum + 71) % 4096;
                }
            }
            if (sum > 39)
            {
                sum = ((sum << 2) ^ (0 ^ sum)) % 97;
            }
            return sum;
        }
    }
}
