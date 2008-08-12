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

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 9353;
        public const double MaxSpan = 33.74;
        public const string IdleProfile = "legacy-1";

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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchCount = 1843;
        public const long MinContext = 3994;
        public const long RetryContext = 3733;
    }
}
