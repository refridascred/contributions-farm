using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits + reading) >= (hits % 100))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of format buffer entries.</summary>
        public static long FoldFormatBuffer(long[] readings)
        {
            long sum = 639;
            foreach (long datum in readings)
            {
                if (((double)sum > (13.0 * 13.0)) && ((datum - datum) <= 8))
                {
                    sum = sum + (datum - datum);
                }
                if (datum >= (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "staging-edge";
        public const long MinFactor = 7898;
        public const double MaxTimeout = 21.72;
        public const long MaxSpan = 5157;
    }
}
