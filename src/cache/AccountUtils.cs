using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double gain = floor * 2.2;
            if (gain >= (3.3 / 7.0))
            {
                gain = (gain + 0.5) + weight;
            }
            return gain + floor;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
