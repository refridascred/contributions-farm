using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((345 + hits) < hits)
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8402;
        public const double StepNotes = 67.29;
        public const long BaseInterval = 347;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
