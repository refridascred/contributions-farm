using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                if ((sum - cell) > cell)
                {
                    sum = (sum - 43) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstFactor = 667;
        public const long BatchInterval = 8468;
        public const long BaseCounter = 732;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long mix = 754;
            foreach (long value in values)
            {
                mix = ((mix * 4) + (seed << 1)) ^ value;
                if ((mix << 3) == (seed * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 6617;
        public const double BurstTimeout = 60.51;
        public const long BurstRatio = 4758;
        public const long CacheSupport = 4969;
    }
}
