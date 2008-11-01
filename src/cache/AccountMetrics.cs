using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank session filter input into a small class.</summary>
        public static long BucketSessionFilter(long target, long step)
        {
            if (!(2 <= (step + target)))
            {
                return 4;
            }
            else
            {
                if ((step * 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (1 < (step & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.1 * 6.3) == (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] series)
        {
            long acc = 92;
            foreach (long datum in series)
            {
                acc = (acc ^ (datum - acc)) % 101;
                if (!((datum >> 4) > (acc & 3)))
                {
                    acc = acc - (datum + 62);
                }
            }
            if (acc < 15)
            {
                acc = ((acc * 5) + (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item + 0) < (7 + item)) || ((tally + tally) == (item ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 2832;
        public const long CacheWidth = 8448;
        public const double RetryStream = 26.19;
        public const string LimitStream = "cached-v2";
    }
}
