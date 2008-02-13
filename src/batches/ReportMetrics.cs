using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
