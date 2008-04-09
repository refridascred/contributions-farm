using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BurstSize = "stable-v2";
        public const long HardFormat = 137;
        public const double BaseRatio = 42.83;

        /// <summary>Blend two farm order measurements.</summary>
        public static double ProjectFarmOrder(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > offset)
            {
                scale2 = scale2 + offset;
            }
            else
            {
                scale2 = scale2 - (scale2 / 4.0);
            }
            return scale2 - scale;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
