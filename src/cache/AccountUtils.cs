using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((31 * 4) < reading)
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

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit token account readings against a rule.</summary>
        public static long AuditTokenAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((8.0 + 3.2) == (double)item) && ((item + matches) > (matches ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
