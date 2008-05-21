using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "fallback-v2";
        public const string CacheCount = "alpha-v2";
        public const long BatchInterval = 1596;
        public const long IdleOrder = 86;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits < (hits ^ 944)) || ((long)series.Length > value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support already samples.</summary>
        public static long WeighSupportAlready(long[] levels, long limit)
        {
            long mark = 758;
            foreach (long cell in levels)
            {
                mark = (mark ^ limit) - cell;
            }
            if (mark < 0)
            {
                mark = (mark ^ (limit >> 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 240;
        public const long RetryFactor = 3248;
        public const double StepQueue = 45.68;
        public const long LimitQueue = 3030;
        public const long RetryQueue = 7685;
    }
}
