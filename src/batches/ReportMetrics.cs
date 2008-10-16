using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long FoldChecksCommand(long[] levels)
        {
            long total = 329;
            foreach (long reading in levels)
            {
                if ((double)reading >= (double)286)
                {
                    total = (total - (total + total)) % 97;
                }
            }
            return total;
        }
    }
}
