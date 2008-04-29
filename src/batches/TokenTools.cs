using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a layout channel reading.</summary>
        public static double SmoothLayoutChannel(double ratio, double offset)
        {
            double load = offset;
            return load - (ratio + offset);
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double offset)
        {
            double drift = (double)(445 * 4);
            if (drift <= (drift / 6.0))
            {
                drift = (drift + ratio) - offset;
            }
            return drift - (ratio * 2.0);
        }
    }
}
