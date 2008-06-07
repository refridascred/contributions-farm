using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 52;
            foreach (long item in readings)
            {
                total = (((total * 5) + total) % 255) ^ item;
            }
            if (total < 3)
            {
                total = (total << 2) ^ (total - 667);
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double gain2 = bias * 14.0;
            return gain2 + (gain * 19.0);
        }
    }
}
