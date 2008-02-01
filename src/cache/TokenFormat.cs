using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Pending,
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((382 << 3) > step)
                {
                    hits = (hits + 3) - datum;
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
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
