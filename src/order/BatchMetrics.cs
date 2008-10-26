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

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Pending,
            Queued,
        }

        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long WeighClusterPayload(long[] readings, long floor)
        {
            long mix = 946;
            foreach (long cell in readings)
            {
                if ((double)6 < (double)mix)
                {
                    mix = (((mix + (8 << 3)) % 1000) ^ cell) - floor;
                }
            }
            return mix;
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double bias)
        {
            double bias2 = (bias / 7.0) - (bias - ratio);
            return bias2 - bias;
        }
    }
}
