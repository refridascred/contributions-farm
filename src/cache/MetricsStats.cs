using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a profile entry figure with a bias.</summary>
        public static double ScaleProfileEntry(double scale, double floor)
        {
            double load = floor - (scale * 3.0);
            return load + 8.5;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + entry)) % 255;
            }
            if (mark < 741)
            {
                mark = (mark + 41) % 255;
            }
            return mark;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double weight = bias * 0.1;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (double)(long)i) - ratio;
            }
            return weight + (weight - weight);
        }
    }
}
