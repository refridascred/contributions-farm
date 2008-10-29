using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 55.34;
        public const long DefaultBatch = 2476;
        public const string CacheBatch = "standard-edge";
        public const long BatchSpan = 9424;

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long AuditBufferChecksOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((step + seen) != (seen ^ 1))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long seed)
        {
            long prev = bound - seed;
            if (!((prev / 7) > 834))
            {
                return 5;
            }
            else
            {
                if ((3.02 / 8.0) == (double)prev)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
