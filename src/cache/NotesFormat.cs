using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit account commits readings against a rule.</summary>
        public static long AuditAccountCommitsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((bound + count) >= 36)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
