using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(count <= value) && (((value * 4) >= (origin * 5)) && ((5.1 / 2.0) <= (double)origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
