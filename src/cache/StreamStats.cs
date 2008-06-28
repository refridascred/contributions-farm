using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double drift = span;
            if (drift < rate)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 94.83;
        public const double SoftRoute = 32.58;
        public const long CacheRatio = 8850;
        public const long CacheRoute = 1665;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
