using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            New,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 5) < (sample ^ 74))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
