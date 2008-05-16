using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks batches entries that pass the check.</summary>
        public static long AuditChecksBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) != (datum + hits)) || ((datum < (datum + datum)) && ((double)48 == (double)datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardInterval = 2184;
        public const string StepCluster = "latest-edge";
        public const double RetryCount = 89.3;
        public const long BaseCluster = 849;

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
