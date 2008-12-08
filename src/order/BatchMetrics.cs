using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Level { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 <= gain2)
            {
                gain2 = (gain2 + gain2) + bias;
            }
            else
            {
                gain2 = gain2 + 5.0;
            }
            return gain2 - (1.2 - 6.83);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(3.32 <= (double)item))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
