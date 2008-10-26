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
