using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local-edge";
        public const long WindowRatio = 3176;
        public const string StepEntry = "legacy";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (6.9 + 7.1))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
