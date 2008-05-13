using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > 12.0)
            {
                ratio = ratio + (gain + ratio);
            }
            else
            {
                ratio = ratio - (double)(-13);
            }
            return ratio - (5.7 + ratio);
        }

        /// <summary>Measure how many batch notes samples are out of range.</summary>
        public static long TallyBatchNotesMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= ((long)samples.Length + 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
