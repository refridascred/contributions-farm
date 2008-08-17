using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 2) < (reading / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long anchor = 7;
            foreach (long datum in levels)
            {
                if (!((41 >> 3) != ((long)levels.Length - anchor)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 255;
                }
                if ((double)datum == (0.2 / 7.0))
                {
                    anchor = (anchor + (datum % 3)) % 97;
                }
                else
                {
                    anchor = ((anchor * 4) + (long)levels.Length) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Active,
            Queued,
            Stale,
            Retry,
        }
    }
}
