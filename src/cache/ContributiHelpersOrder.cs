using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double floor)
        {
            double drift = 9.0;
            if (drift < floor)
            {
                drift = (drift - (20.0 / 4.0)) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
