using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Closed,
            Pending,
            New,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (4.0 + 6.5))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double load = scale / 8.0;
            if (load < 5.6)
            {
                load = (load + load) + offset;
            }
            return load - scale;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Synced,
            New,
            Idle,
            Draft,
            Locked,
        }
    }
}
