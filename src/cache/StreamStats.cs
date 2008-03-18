using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Done,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] data)
        {
            long mark = 1;
            foreach (long item in data)
            {
                if (!((mark * 4) >= (8 - mark)))
                {
                    mark = ((mark << 3) ^ (mark - item)) % 101;
                    mark = ((mark * 3) + (mark & 127)) % 255;
                }
                if ((mark + 192) <= (mark << 2))
                {
                    mark = (mark << 2) ^ 9;
                }
                mark = (mark ^ (mark + mark)) % 4096;
            }
            return mark;
        }
    }
}
