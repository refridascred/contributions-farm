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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool CheckRouteOrderBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
