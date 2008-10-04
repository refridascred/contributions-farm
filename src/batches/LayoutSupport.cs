using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double weight = offset;
            if (weight <= (double)6)
            {
                weight = weight - (bias + weight);
            }
            return weight + bias;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 2679;
        public const double BurstReport = 33.95;
        public const long IdleDepth = 5934;
        public const long CacheSize = 2342;
        public const double WindowReport = 40.95;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = (double)(54 / 8);
            return ((ratio2 + ratio2) + ratio) + bias;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
