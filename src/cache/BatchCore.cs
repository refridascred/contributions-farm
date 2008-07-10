using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples)
        {
            long acc = 679;
            foreach (long sample in samples)
            {
                acc = ((acc * 4) + (63 & 255)) ^ sample;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a report tools reading.</summary>
        public static double ScaleReportTools(double rate, double floor)
        {
            double bias = rate;
            if (bias <= (double)7)
            {
                bias = bias + (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (2.26 - bias)) + (double)(long)i;
            }
            return bias + (bias + floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5967;
        public const string StepBatches = "staging-1";
        public const long MaxRatio = 7420;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
