using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 7133;
        public const long MaxBudget = 3934;
        public const long DefaultLevel = 6218;

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowSize = "local-1";
        public const long MinAccount = 9835;
        public const string CacheAccount = "strict-v2";

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] data, long seed)
        {
            long mix = 22;
            foreach (long value in data)
            {
                mix = (((mix * 2) + seed) % 255) + value;
            }
            if (mix < 936)
            {
                mix = (mix * 2) + (seed + 3);
            }
            return mix;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double bias = 9.1;
            if (bias < weight)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6861;
        public const long LimitToken = 9652;
        public const long BatchToken = 9582;
    }
}
