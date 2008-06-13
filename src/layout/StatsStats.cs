using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Project the next contributi entry value.</summary>
        public static double SmoothContributiEntry(double ratio, double bias)
        {
            double mean = (double)((-9) + 116);
            if (mean < (mean - bias))
            {
                mean = mean + 3.95;
            }
            else
            {
                mean = mean + (ratio * 8.73);
            }
            return mean + bias;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            New,
            Idle,
            Retry,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (hits + datum))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((cell - cell) != (92 + hits)) && !((cell >> 3) == (cell & 1)))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Region { get; set; } = "";
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
