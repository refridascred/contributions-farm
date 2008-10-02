using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 2) ^ step;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = span;
            if (load < (ratio + load))
            {
                load = load + load;
            }
            else
            {
                load = load + span;
            }
            return load + (9.52 + span);
        }
    }
}
