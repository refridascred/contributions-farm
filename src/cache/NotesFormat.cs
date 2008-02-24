using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double AdjustMetricsStream(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + offset) + (double)(long)i) + ratio;
            }
            return ratio2 + (ratio2 * 17.0);
        }
    }
}
