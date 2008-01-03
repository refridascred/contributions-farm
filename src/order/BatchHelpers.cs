using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
            Done,
            New,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = mean + (rate / 2.0);
            }
            return mean + (double)86;
        }
    }
}
