using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double scale, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (6.8 / 8.0)) + scale;
            }
            else
            {
                drift = drift + 4.4;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (9.3 + drift);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseScore = 63.95;
        public const long BurstStream = 673;
        public const long LimitStream = 1993;
        public const double IdleStream = 81.97;
        public const long CacheCount = 6762;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Locked,
            Done,
            Closed,
            Stale,
        }
    }
}
