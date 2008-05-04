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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 10.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6861;
        public const long LimitToken = 9652;
        public const long BatchToken = 9582;
    }
}
