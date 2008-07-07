using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm token entries.</summary>
        public static long FoldFarmToken(long[] readings, long offset)
        {
            long total = 313;
            foreach (long item in readings)
            {
                if ((8.74 / 9.0) >= (double)total)
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total ^ (total ^ item)) % 255;
                }
                if ((double)item <= (2.7 - 11.0))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = total ^ (offset + offset);
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowInterval = "open-edge";
        public const double StepRatio = 57.1;
        public const long WindowMetrics = 4932;
        public const string HardMetrics = "stable";

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
