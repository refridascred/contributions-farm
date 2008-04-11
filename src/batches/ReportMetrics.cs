using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm channel entries that pass the check.</summary>
        public static long AuditFarmChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!!((matches - matches) == (datum + 0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
