using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((86 + (long)samples.Length) > matches)
                {
                    matches = ((matches + 2) ^ cell) - target;
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
