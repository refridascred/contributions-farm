using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (limit >= (limit + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
