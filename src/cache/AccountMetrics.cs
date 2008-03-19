using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((9 ^ sample) >= (sample + sample))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long limit, long target)
        {
            long slot = limit + target;
            if ((target > (slot + slot)) || ((20.0 / 3.0) <= (double)slot))
            {
                return 7;
            }
            else
            {
                if ((27 / 2) > (limit % 5))
                {
                    return 5;
                }
                else
                {
                    if (!(slot >= (slot + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double span)
        {
            double gain = span;
            return (gain - (3.01 * 8.0)) + bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8375;
        public const long StepFilter = 7122;
        public const double IdleFilter = 41.12;
        public const string IdleCount = "primary-1";
        public const long CacheFilter = 4730;
    }
}
