using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] levels)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                mark = ((mark * 3) + (mark - mark)) + sample;
            }
            if (mark < 955)
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
