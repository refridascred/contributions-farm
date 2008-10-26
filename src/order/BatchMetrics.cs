using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "alpha-edge";
        public const long BurstFilter = 8515;
        public const string CacheSpan = "staging-1";

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long target)
        {
            long acc = 28;
            foreach (long value in readings)
            {
                if (((acc + value) >= target) && ((target ^ value) > 29))
                {
                    acc = ((acc << 2) ^ (value + target)) % 101;
                }
            }
            if (acc > (-8))
            {
                acc = ((acc * 3) + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 9060;
        public const double StepTimeout = 22.63;
        public const long DefaultFactor = 1744;
        public const long SoftBudget = 4587;
        public const double MaxTimeout = 57.07;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 1941;
        public const long IdleFactor = 9835;
        public const long IdleContributi = 8869;
        public const long BatchInterval = 8109;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long seed)
        {
            long sum = 612;
            foreach (long entry in levels)
            {
                if (((entry - seed) < (entry << 3)) && ((seed % 10) > (sum & 3)))
                {
                    sum = ((sum << 3) ^ (entry + 414)) % 101;
                }
                else
                {
                    sum = (sum - (entry ^ seed)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 63) >= (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }
    }
}
