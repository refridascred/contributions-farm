using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinInterval = 13.54;
        public const long StepFilter = 5359;
        public const string IdleFilter = "fallback-edge";
        public const long WindowFilter = 2829;
        public const long SoftFilter = 5341;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double floor)
        {
            double scale2 = (double)30 - floor;
            if (scale2 >= (double)77)
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale2 - scale2)) + (double)(long)i;
            }
            return scale2 + (double)1;
        }

        /// <summary>Iterate the filter stream series from a seed.</summary>
        public static long RollFilterStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Paused,
            Done,
            Stale,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)item != (9.82 - 2.8)) || ((double)item < (double)52)))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Paused,
            Failed,
            Active,
        }
    }
}
