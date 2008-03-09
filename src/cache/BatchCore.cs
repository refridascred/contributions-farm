using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long AuditTokenCacheOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((entry & 7) <= (7 - matches)) && ((4 + matches) < (matches + 303)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) == (datum % 97))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
