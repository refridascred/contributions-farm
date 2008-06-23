using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double span)
        {
            double ratio = span;
            return ratio + weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultBudget = "primary-1";
        public const long WindowGraph = 5362;
        public const long DefaultRatio = 8931;
        public const long DefaultLevel = 8558;
        public const double StepGraph = 64.6;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
