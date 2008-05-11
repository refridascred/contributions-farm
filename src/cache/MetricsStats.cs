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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((9.9 / 8.0) > (double)seen))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 42;
            foreach (long item in levels)
            {
                anchor = anchor - (anchor + item);
            }
            if (anchor < 69)
            {
                anchor = (anchor ^ 85) % 101;
            }
            return anchor;
        }
    }
}
