using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 0;
            foreach (long value in samples)
            {
                anchor = (anchor + anchor) + value;
            }
            if (anchor < 14)
            {
                anchor = anchor + (anchor + 30);
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long offset)
        {
            long mark = 123;
            foreach (long entry in data)
            {
                if ((double)offset >= (double)66)
                {
                    mark = (((mark * 4) + (774 - offset)) % 101) - entry;
                }
                mark = mark - (mark + offset);
                mark = mark - (offset % 97);
            }
            if (mark > 590)
            {
                mark = (mark + (offset + (long)data.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWidth = 91.63;
        public const long SoftSpan = 377;
        public const string IdleWindow = "cached";
        public const double IdleInterval = 11.0;
        public const long HardFactor = 1261;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
