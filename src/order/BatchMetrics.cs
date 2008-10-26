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

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 7442;
        public const long MaxInterval = 8203;
        public const double RetryGraph = 57.91;

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
