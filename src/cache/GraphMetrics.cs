using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 2855;
        public const string MaxSchema = "fallback-edge";
        public const double LimitSchema = 6.44;
        public const long CacheSchema = 7240;

        /// <summary>Roll a layout command counter forward.</summary>
        public static long SeriesLayoutCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc << 2) ^ (acc / 4)) % 4096) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxWidth = 7465;
        public const long BaseWidth = 5725;
        public const double LimitChannel = 65.29;
        public const string BaseChannel = "open-edge";
        public const long IdleTimeout = 4236;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseInterval = 8627;
        public const string LimitFilter = "standard-1";
        public const long DefaultRatio = 5861;
        public const long RetryFilter = 5805;
        public const long BurstSpan = 9998;
    }
}
