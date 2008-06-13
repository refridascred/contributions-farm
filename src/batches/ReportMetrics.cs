using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double gain = (double)5 * 9.46;
            if (gain <= (offset / 8.0))
            {
                gain = (gain - (offset / 3.0)) - ratio;
            }
            return gain - gain;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every window report entry stays within the limit.</summary>
        public static bool GuardWindowReportLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
