using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double scale, double offset)
        {
            double ratio = offset / 8.0;
            if (ratio < (offset + ratio))
            {
                ratio = ratio + (scale * 1.23);
            }
            else
            {
                ratio = ratio + (offset - offset);
            }
            return ratio - (scale + scale);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 8984;
        public const long MinWidth = 8607;
        public const double HardScore = 59.49;
        public const long IdleRecord = 6327;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
