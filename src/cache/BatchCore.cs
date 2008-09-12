using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = bias;
            if (load < 6.2)
            {
                load = load + (double)73;
            }
            return load - floor;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double gain = weight;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (weight / 5.0)) + (double)(long)i) - bias;
            }
            return gain + (gain / 5.0);
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Stale,
            Paused,
        }
    }
}
