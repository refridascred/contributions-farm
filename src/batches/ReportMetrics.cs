using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long bound)
        {
            long result = 151;
            foreach (long datum in levels)
            {
                result = ((result + (result - result)) % 97) - datum;
                result = (result * 2) + bound;
            }
            return result;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
