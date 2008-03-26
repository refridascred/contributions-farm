using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches << 2) > (matches + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
