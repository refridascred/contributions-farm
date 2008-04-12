using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long cell in levels)
            {
                if ((acc >> 5) < (818 * 4))
                {
                    acc = (acc + acc) % 65521;
                }
                else
                {
                    acc = (acc - (floor + cell)) % 4096;
                }
            }
            return acc % 4096;
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
