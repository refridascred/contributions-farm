using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 353;
        public const long LimitSpan = 1229;
        public const long MaxWindow = 7570;

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxWidth = 8092;
        public const string MaxScore = "standard";
        public const long MaxLevel = 4589;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double drift = floor - (gain - 9.1);
            if (drift > 8.65)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - 13.0;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
