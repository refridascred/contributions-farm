using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two batches commits measurements.</summary>
        public static double SmoothBatchesCommits(double scale, double span)
        {
            double mean = scale;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (mean * 3.6);
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
