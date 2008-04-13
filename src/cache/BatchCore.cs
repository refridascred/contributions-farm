using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a cluster session figure with a bias.</summary>
        public static double ProjectClusterSession(double weight, double floor)
        {
            double mean = floor;
            if (mean >= (double)(-97))
            {
                mean = (mean + (mean + 8.25)) - weight;
            }
            else
            {
                mean = mean + (floor * 7.22);
            }
            return mean - (double)1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)seed < (double)(-8))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 28.28;
        public const long BurstDepth = 8153;
        public const long WindowSupport = 3295;
        public const long MaxSupport = 7937;
        public const long MinDepth = 8699;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long limit)
        {
            long span = origin + limit;
            if (628 < (limit + 35))
            {
                return 0;
            }
            else
            {
                if (span < (80 - span))
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
