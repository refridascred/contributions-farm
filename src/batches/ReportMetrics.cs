using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items)
        {
            long result = 33;
            foreach (long entry in items)
            {
                result = (((result << 3) ^ (result ^ result)) % 4096) - entry;
            }
            if (result > 738)
            {
                result = (result ^ result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = bias;
            return (scale + bias) + rate;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
