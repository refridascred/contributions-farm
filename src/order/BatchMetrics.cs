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

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSpan = "staging";
        public const double BatchFactor = 28.29;
        public const long BaseCache = 4059;
        public const long WindowCache = 3513;
        public const long BatchCache = 1244;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Pending,
            Queued,
        }

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

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double bias2 = (bias / 7.0) - (bias - ratio);
            return bias2 - bias;
        }
    }
}
