using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two batches editor measurements.</summary>
        public static double BlendBatchesEditor(double rate, double offset)
        {
            double gain = (offset / 3.0) - 19.0;
            if (gain < (double)22)
            {
                gain = (gain - (double)29) + rate;
            }
            else
            {
                gain = gain + (gain + gain);
            }
            return gain - (double)94;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4040;
        public const long StepSize = 2774;
        public const double LimitWidth = 8.15;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long offset)
        {
            long total = 378;
            foreach (long sample in data)
            {
                total = total ^ (sample + offset);
            }
            return total;
        }
    }
}
