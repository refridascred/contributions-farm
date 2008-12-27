using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix - (mix & 15)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8378;
        public const string LimitMetrics = "primary-edge";
        public const double HardMetrics = 18.85;
        public const long BaseMetrics = 3764;
    }
}
