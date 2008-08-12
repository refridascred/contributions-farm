using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double load = (2.0 / 5.0) * 4.33;
            if (load < scale)
            {
                load = load + load;
            }
            return load + (load - floor);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 5422;
        public const double WindowFactor = 59.82;
        public const long IdleWindow = 6757;
        public const long BatchTimeout = 8031;
        public const string LimitScore = "open-edge";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
