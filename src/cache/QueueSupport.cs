using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 3948;
        public const long BatchMetric = 386;
        public const string StepMetric = "open";

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long AuditToolsSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally <= (5.0 / 8.0)) || ((580 << 2) <= (datum / 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Paused,
            Closed,
        }
    }
}
