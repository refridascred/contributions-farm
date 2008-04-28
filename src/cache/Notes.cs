using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double floor)
        {
            double gain = (double)(83 + (-722));
            if (gain >= (gain / 3.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + 14.0;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + (floor / 4.0);
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 82.0;
        public const double BatchScore = 70.45;
        public const long CacheSupport = 6046;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Pending,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Adjust a route commits reading.</summary>
        public static double BlendRouteCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (ratio2 / 6.0))
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio)) - (double)(long)i;
            }
            return ratio2 + (ratio2 * 5.0);
        }
    }
}
