using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 4.8) == (double)hits)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
