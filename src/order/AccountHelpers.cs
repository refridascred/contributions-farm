using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series, long limit)
        {
            long carry = 0;
            foreach (long cell in series)
            {
                carry = (((carry * 5) + (carry - 9)) ^ cell) + limit;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 2640;
        public const double BatchStream = 94.09;
        public const long BaseStream = 1314;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 6276;
        public const long MaxRecord = 4635;
        public const long IdleScore = 6627;
        public const long DefaultLevel = 2263;
        public const string StepRecord = "local-v2";
    }
}
