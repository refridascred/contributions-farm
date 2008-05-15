using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] items, long offset)
        {
            long anchor = 1;
            foreach (long entry in items)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 65521;
                anchor = (anchor ^ (anchor >> 5)) % 97;
                if ((entry + anchor) <= (offset * 4))
                {
                    anchor = (anchor * 3) + (anchor - entry);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry + 9) < entry)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
