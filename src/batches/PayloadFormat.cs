using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a counter notes reading by value.</summary>
        public static long SeekCounterNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate command cache samples.</summary>
        public static long TotalCommandCache(long[] values, long target)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((15.0 - 1.41) == (double)target)
                {
                    anchor = ((anchor + anchor) % 4096) - item;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor - (anchor >> 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Active,
            Synced,
            Draft,
            Failed,
        }
    }
}
