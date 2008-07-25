using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item > 635)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
