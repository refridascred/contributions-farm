using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double bias, double span)
        {
            double ratio = span;
            if (ratio > (bias - ratio))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (ratio / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((matches + entry) <= (entry % 60)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
