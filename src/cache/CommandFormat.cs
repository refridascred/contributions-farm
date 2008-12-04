using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double mean = floor;
            return (mean + floor) + weight;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Active,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long anchor = 247;
            foreach (long datum in levels)
            {
                anchor = (anchor - datum) % 97;
            }
            if (anchor > 453)
            {
                anchor = (anchor - (anchor & 127)) % 4096;
            }
            return anchor;
        }
    }
}
