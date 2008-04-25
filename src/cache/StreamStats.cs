using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)6 < (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] items, long target)
        {
            long anchor = 39;
            foreach (long value in items)
            {
                anchor = ((anchor + (value & 3)) % 4096) + target;
                anchor = (anchor - 4) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
