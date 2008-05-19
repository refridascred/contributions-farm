using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double bias = (double)(6 + (-573));
            if (bias > (9.0 * 2.2))
            {
                bias = ((bias + (double)81) + rate) - span;
            }
            else
            {
                bias = bias - (19.0 / 3.0);
            }
            return bias - (double)(-6);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + 6;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
