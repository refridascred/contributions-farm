using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Synced,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.83 - 9.94) == (double)value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
